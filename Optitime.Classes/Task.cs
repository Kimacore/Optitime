using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optitime.Classes
{
    [Index(nameof(TaskName), IsUnique = true)]
    public class Task
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(150)]
        [Required]
        public string? TaskName { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        public Guid ProjectId { get; set; }
        [Required]
        public Guid AssignedToUserId { get; set; }
        [MaxLength(50)]
        public string? Status { get; set; }
        [Required]
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public virtual Project? Project { get; set; }
        [ForeignKey(nameof(AssignedToUserId))]
        public virtual User? AssignedToUser { get; set; }
    }
}
