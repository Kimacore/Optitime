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
    public class TimeEntry
    {
        [Key]
        public int TimeEntryId { get; set; }
        public int? UserId { get; set; }
        public int? TeamId { get; set; }
        public int TaskId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Duration { get; set; }

        public User User { get; set; }
        public Team Team { get; set; }
        public Task Task { get; set; }
        public Project Project { get; set; }
    }
}
