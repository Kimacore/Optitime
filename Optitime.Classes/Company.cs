using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optitime.Classes
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [MaxLength(150)]
        [Required]
        public string CompanyName { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string Industry { get; set; }
    }
}
