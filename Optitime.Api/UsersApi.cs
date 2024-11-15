using Optitime.Classes;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Optitime.Api
{
    public static class UsersApi
    {
        public static RouteGroupBuilder MapUsersApi(this RouteGroupBuilder api) {
            

            //insert пользователей 
            api.MapPost("/", async (UserDto user, AppDbContext db) => {
                ArgumentNullException.ThrowIfNull(user?.Name);

                var userRole = await db.AppRole
                       .Where(r => r.RoleName == "User")
                       .Select(r => r.Id)
                       .FirstOrDefaultAsync();

                if (userRole == null)
                {
                    return Results.BadRequest("Роль 'User' не найдена.");
                }

                db.User.Add(new User
                {
                    Id = Guid.NewGuid(),
                    Name = user.Name,
                    LastName = user.LastName,
                    Email = user.Email,
                    Login = user.Login,
                    ApplicationRoleId = userRole
                });

                await db.SaveChangesAsync();

                return Results.Ok();
            });

            // select all
            api.MapGet("/", async (AppDbContext db) =>
            {
                var users = await
                    db.User
                      .Select(u => new UserDto(u))
                      .ToListAsync();

                return Results.Ok(users);
            });

            // select by name
            api.MapGet("/name/{name}", async (string name, AppDbContext db) =>
            {
                var user = await
                    db.User
                      .FirstOrDefaultAsync(u => u.Name == name);

                if (user is null)
                    return Results.NotFound();

                return Results.Ok(new UserDto(user));
            });
            // select by login
            api.MapGet("/login/{login}", async (string login, AppDbContext db) =>
            {
                var user = await
                    db.User
                      .FirstOrDefaultAsync(u => u.Login == login);

                if (user is null)
                    return Results.NotFound();

                return Results.Ok(new UserDto(user));
            });

            // update by login
            api.MapPut("/login/{login}", async (string login, UserDto user, AppDbContext db) =>
            {
                ArgumentNullException.ThrowIfNull(user);

                var usr = await
                    db.User
                      .FirstOrDefaultAsync(u => u.Login == login);

                if (usr is null)
                    return Results.BadRequest($"Login '{login}' not found");
                usr.Name = user.Name;
                usr.LastName = user.LastName;

                await db.SaveChangesAsync();

                return Results.Ok();
            });

            // delete by login
            api.MapDelete("/name/{login}", async (string login, AppDbContext db) =>
            {
                var user = await
                    db.User
                      .FirstOrDefaultAsync(u => u.Name == login);

                if (user is null)
                    return Results.BadRequest($"User '{login}' not found");

                db.Remove(user);
                await db.SaveChangesAsync();

                return Results.Ok();
            });

            // get login user info
            api.MapGet("/current", (HttpContext context) =>
            {
                var username = context.User.Identity?.Name;
                var userid = Guid.Parse(context.User.FindFirst("id")!.Value);
                var usermail = context.User.FindFirst(ClaimTypes.Email)?.Value;
                return Results.Ok(new { Name = username, Id = userid, Email = usermail });
            });
                
            return api;
        }
    }
}
