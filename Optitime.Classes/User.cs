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
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(32)]
        [Required]
        public string Login { get; set; }

        [EmailAddress]
        [MaxLength(128)]
        [Required]
        public string Email { get; set; }

        [InverseProperty(nameof(UserPassword.User))]
        public virtual UserPassword? Password { get; set; }

        public Guid? DepartmentId { get; set; }
        public Guid? TeamId { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid? RoleId { get; set; }

        // Навигационные свойства
        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; set; }
        [ForeignKey(nameof(TeamId))]
        public virtual Team Team { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public virtual Company Company { get; set; }
        [ForeignKey(nameof(RoleId))]
        public virtual Role Role { get; set; }
    }
}
