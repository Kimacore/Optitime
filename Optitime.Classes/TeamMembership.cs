using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Optitime.Classes
{
    public class TeamMembership
    {
        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public Guid TeamId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(TeamId))]
        public Team Team { get; set; }
    }
}
