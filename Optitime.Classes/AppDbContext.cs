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
        public DbSet<User> User { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<TimeEntry> TimeEntry { get; set; }
        public DbSet<Admin> Admin {  get; set; }
        public DbSet<AdminPassword> AdminPassword { get; set; }
        public DbSet<ApplicationRole> AppRole { get; set; }
        public DbSet<OrganizationRole> OrgRole { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<TeamMembership> TeamMembership { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<UserPassword> UserPassword { get; set; }
        public DbSet<OrgRolesPrivileges> OrgRolesPrivileges { get; set; }

    }
}
