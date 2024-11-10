using Optitime.Classes;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace Optitime.Api
{
    public static class UsersApi
    {
        public static RouteGroupBuilder MapUsersApi(this RouteGroupBuilder api) {
            api.MapPost("/", async (UserDto user, AppDbContext db) => {
                ArgumentNullException.ThrowIfNull(user?.Name);

                db.User.Add(new User
                {
                    Id = Guid.NewGuid(),
                    Name = user.Name,
                    LastName = user.LastName,
                    Email = user.Email,
                    Login = user.Login,
                });

                await db.SaveChangesAsync();

                return Results.Ok();
            });


            return api;
        }
    }
}
