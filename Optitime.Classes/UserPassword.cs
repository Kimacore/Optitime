﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optitime.Classes
{
    public class UserPassword
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public required string PasswordHash { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(User.Password))]
        public virtual User? User { get; set; }
    }
}
