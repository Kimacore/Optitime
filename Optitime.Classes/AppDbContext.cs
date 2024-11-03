using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optitime.Classes
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> users { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Task> tasks { get; set; }
        public DbSet<TimeEntry> timeentries { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<TeamMembership> teammemberships { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<UserPassword> userpasswords { get; set; }

    }
}
