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
    [Index(nameof(Name), IsUnique = true)]
    public class Department
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [Required]
        public Guid CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; }
    }
}
