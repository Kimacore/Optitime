using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Optitime.Classes
{
    public class OrgRolesPrivileges
    {
        [Key]
        public Guid Id { get; set; }

        public Guid PrivilegeId { get; set; }
        [ForeignKey(nameof(PrivilegeId))]
        public virtual Privilege? Privilege { get; set; }

        public Guid OrganizationRoleId { get; set; }
        [ForeignKey(nameof(OrganizationRoleId))]
        public virtual OrganizationRole? OrganizationRole { get; set; }
    }
}
