using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optitime.Classes
{
    [Index(nameof(DepartmentName), IsUnique = true)]
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [MaxLength(100)]
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
