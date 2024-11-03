using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace Optitime.Migrations
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<Optitime.Classes.AppDbContext>
    {
        public Optitime.Classes.AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Optitime.Classes.AppDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=optitime;Username=postgres;Password=student", options => options.MigrationsAssembly("Optitime.Migrations"));

            return new Optitime.Classes.AppDbContext(optionsBuilder.Options);
        }
    }
}
