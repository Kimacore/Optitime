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
    public class TimeEntry
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public Guid? TeamId { get; set; }
        public Guid TaskId { get; set; }
        public Guid? ProjectId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Duration { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [ForeignKey(nameof(TeamId))]
        public Team Team { get; set; }
        [ForeignKey(nameof(TaskId))]
        public Task Task { get; set; }
        [ForeignKey(nameof(ProjectId))]
        public Project Project { get; set; }
    }
}
