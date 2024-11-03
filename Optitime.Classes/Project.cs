using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optitime.Classes
{
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
}
