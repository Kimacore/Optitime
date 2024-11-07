using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optitime.Classes
{
    public class Admin
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(100)]
        public string AdminUsername { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [InverseProperty(nameof(AdminPassword.Admin))]
        public virtual AdminPassword? Password { get; set; }

    }
}
