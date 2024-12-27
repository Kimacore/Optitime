using System.Security.Cryptography;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Optitime.Classes;
using Optitime.Api;
using Microsoft.AspNetCore.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var configuration = builder.Configuration;

services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseNpgsql(configuration.GetConnectionString("Optitime"), optionsBuilder =>
    {
        // Настраиваем стратегию повторных попыток при временных сбоях
        optionsBuilder.EnableRetryOnFailure(
            maxRetryCount: 5, // Максимальное количество повторов
            maxRetryDelay: TimeSpan.FromSeconds(10), // Максимальная задержка между попытками
            errorCodesToAdd: null // Дополнительные коды ошибок, которые нужно обработать
        );
    });
});

services.AddCors(options =>
{
    options.AddPolicy("AllowVueApp", builder =>
    {
        builder.WithOrigins("http://localhost:5173")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(configuration["JWT:Key"]!)),
        ValidateAudience = false,
        ClockSkew = TimeSpan.Zero

    };
});

services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
        options.JsonSerializerOptions.WriteIndented = true; // Для форматирования JSON, если нужно
    });

services.AddAuthorization();
var app = builder.Build();
app.UseCors("AllowVueApp");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", () => "Optitime Service");

app.MapGroup("/users").MapUsersApi();
app.MapGroup("/roles").MapRolesApi().RequireAuthorization(e => e.RequireRole("Admin"));
app.MapGroup("/projects").MapProjectsApi();
app.MapPost("/login/{username}",
    async (string username, [FromBody] string password, AppDbContext db) =>
    {
        var user = await
            db.User.FirstOrDefaultAsync(u => u.Login == username);

        if (user is null || user.Password?.PasswordHash is null)
            return Results.Unauthorized();

        byte[] hash = SHA512.HashData(Encoding.UTF8.GetBytes(password));
        string hex = BitConverter.ToString(hash).Replace("-", "");

        if (hex != user.Password.PasswordHash)
            return Results.Unauthorized();

        var claims = new List<Claim>
    {
        new(ClaimTypes.Name, username),
        new("id", user.Id.ToString()),
        new(ClaimTypes.Role, user.ApplicationRole.RoleName),
        new(ClaimTypes.Email, user.Email)
    };


        var jwt = new JwtSecurityToken(
            claims: claims,
            issuer: configuration["Jwt:Issuer"],
            expires: DateTime.UtcNow.Add(TimeSpan.FromHours(5)),
            signingCredentials:
                new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!)),
                    SecurityAlgorithms.HmacSha256));

        return Results.Ok(new JwtSecurityTokenHandler().WriteToken(jwt));
    });

app.MapPost("/register", async (RegUserDto userdto, AppDbContext db) =>
{
    var existingUser = await db.User.FirstOrDefaultAsync(u => u.Login == userdto.Login || u.Email == userdto.Email);
    if (existingUser != null)
    {
        return Results.BadRequest(new { error = "Пользователь с таким логином или email уже существует." });
    }

    var userId = Guid.NewGuid();
    var userRole = await db.AppRole.FirstOrDefaultAsync(role => role.RoleName == "User");

    db.User.Add(new User
    {
        Id = userId,
        Login = userdto.Login,
        Name = userdto.Name,
        LastName = userdto.LastName,
        Email = userdto.Email,
        ApplicationRoleId = userRole.Id
    });

    byte[] hash = SHA512.HashData(Encoding.UTF8.GetBytes(userdto.Password));
    string hex = BitConverter.ToString(hash).Replace("-", "");

    db.UserPassword.Add(new UserPassword
    {
        Id = Guid.NewGuid(),
        PasswordHash = hex,
        UserId = userId
    });

    await db.SaveChangesAsync();

    var claims = new List<Claim>
    {
        new(ClaimTypes.Name, userdto.Login),
        new("id", userId.ToString()),
        new(ClaimTypes.Role, userRole.RoleName),
        new(ClaimTypes.Email, userdto.Email)
    };

    var jwt = new JwtSecurityToken(
        claims: claims,
        issuer: configuration["Jwt:Issuer"],
        expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(3)),
        signingCredentials: new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
            SecurityAlgorithms.HmacSha256));


    return Results.Ok(new JwtSecurityTokenHandler().WriteToken(jwt));
});

app.Run();