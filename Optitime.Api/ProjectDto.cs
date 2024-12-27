using Optitime.Classes;
using System.ComponentModel.DataAnnotations;

namespace Optitime.Api
{
    public class ProjectDto
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [MaxLength(500)]

        public string Description { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
        [MaxLength(50)]
        [Required]
        public required string Status { get; set; }
        [Required]
        public Guid OwnerId { get; set; }

        public ProjectDto(Project project)
        {
            Id = project.Id;
            Name = project.Name;
            Description = project.Description;
            StartDate = project.StartDate;
            EndDate = project.EndDate;
            Status = project.Status;
            OwnerId = project.OwnerId;
        }
    }

    public record CreateProjectDto(string Name, string Description, DateTime StartDate, DateTime EndDate, string Status, Guid OwnerId);
}
