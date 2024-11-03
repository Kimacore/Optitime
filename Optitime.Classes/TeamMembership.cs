using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Optitime.Classes
{
    public class TeamMembership
    {
        [Key]
        public int TeamMembershipId { get; set; }
        public int UserId { get; set; }
        public int TeamId { get; set; }

        public User User { get; set; }
        public Team Team { get; set; }
    }
}
