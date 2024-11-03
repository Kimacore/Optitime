using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optitime.Classes
{
    [Index(nameof(Name), IsUnique = true)]
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
