﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optitime.Classes
{
    public class ApplicationRole
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string RoleName { get; set; }

        
        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
