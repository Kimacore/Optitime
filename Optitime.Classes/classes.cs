namespace Optitime.Classes
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.EntityFrameworkCore;

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


    }
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        [MaxLength(255)]
        [Required]
        public string Email { get; set; }
        [MaxLength(128)]
        [Required]
        public string PasswordHash { get; set; }

        public int? DepartmentId { get; set; }
        public int? TeamId { get; set; }
        public int? CompanyId { get; set; }
        public int? RoleId { get; set; }

        public Department Department { get; set; }

        public Team Team { get; set; }
        public Company Company { get; set; }
        public Role Role { get; set; }
    }

    [Index(nameof(TeamName), IsUnique = true)]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [MaxLength(100)]
        [Required]
        public string TeamName { get; set; }
        [Required]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
    [Index(nameof(DepartmentName), IsUnique = true)]
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [MaxLength(100)]
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
    [Index(nameof(ProjectName), IsUnique = true)]
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [MaxLength(100)]
        [Required]
        public string ProjectName { get; set; }
        [MaxLength(500)]

        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        [MaxLength(50)]
        [Required]
        public string Status { get; set; }
        [Required]
        public int OwnerId { get; set; }

        public User Owner { get; set; }
    }
    [Index(nameof(TaskName), IsUnique = true)]
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        [MaxLength(150)]
        [Required]
        public string TaskName { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public int? ProjectId { get; set; }
        [Required]
        public int AssignedToUserId { get; set; }
        [MaxLength(50)]
        public string Status { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Project Project { get; set; }
        public User AssignedToUser { get; set; }
    }

    public class TimeEntry
    {
        [Key]
        public int TimeEntryId { get; set; }
        public int? UserId { get; set; }
        public int? TeamId { get; set; }
        public int TaskId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Duration { get; set; }

        public User User { get; set; }
        public Team Team { get; set; }
        public Task Task { get; set; }
        public Project Project { get; set; }
    }
    [Index(nameof(RoleName), IsUnique = true)]
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [MaxLength(50)]
        [Required]
        public string RoleName { get; set; }
    }

    public class TeamMembership
    {
        [Key]
        public int TeamMembershipId { get; set; }
        public int UserId { get; set; }
        public int TeamId { get; set; }

        public User User { get; set; }
        public Team Team { get; set; }
    }

    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [MaxLength(150)]
        [Required]
        public string CompanyName { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string Industry { get; set; }
    }
}
