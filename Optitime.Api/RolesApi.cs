using Optitime.Classes;
using Microsoft.EntityFrameworkCore;
namespace Optitime.Api
{
    public static class RolesApi
    {
        public static RouteGroupBuilder MapRolesApi(this RouteGroupBuilder api)
        {
            api.MapGet("/", async (AppDbContext db) =>
            {
                var roles = await
                    db.AppRole
                    .Select(r => r.RoleName)
                    .ToListAsync();

                return Results.Ok(roles);
            });

            

            return api;

            
        }
    }
}
