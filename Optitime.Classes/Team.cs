using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optitime.Classes
{
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
}
