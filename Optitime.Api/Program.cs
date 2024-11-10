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
services.AddAuthentication();

var app = builder.Build();

app.UseAuthentication();
//app.UseAuthorization();

app.MapGet("/", () => "Optitime Service");

app.MapGroup("/users").MapUsersApi();//.RequireAuthorization();



app.Run();