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

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var configuration = builder.Configuration;

services.AddDbContext<AppDbContext>(opt => 
    opt.UseNpgsql(configuration.GetConnectionString("Optitime")));

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
        ValidateAudience = false
        
    };

});
services.AddAuthorization();
var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/", () => "Optitime Service");

app.MapGroup("/users").MapUsersApi().RequireAuthorization(e => e.RequireRole("Admin"));
app.MapGroup("/roles").MapRolesApi().RequireAuthorization(e => e.RequireRole("Admin"));

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
            expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(10)),
            signingCredentials:
                new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!)),
                    SecurityAlgorithms.HmacSha256));

        return Results.Ok(new JwtSecurityTokenHandler().WriteToken(jwt));
    });
app.Run();