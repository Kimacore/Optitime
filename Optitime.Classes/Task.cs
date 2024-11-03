using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optitime.Classes
{
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
}
