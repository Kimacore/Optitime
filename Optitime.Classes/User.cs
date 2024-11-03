using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optitime.Classes
{
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
}
