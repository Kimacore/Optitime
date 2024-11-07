using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Optitime.Classes
{
    public class UserRole
    {
        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User? User { get; set; }

        public Guid OrganizationRoleId { get; set; }
        [ForeignKey(nameof(OrganizationRoleId))]
        public virtual OrganizationRole? OrganizationRole { get; set; }


    }
}
