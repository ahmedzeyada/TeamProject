using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamService.Models
{
    public class TeamEmployee
    {
        public Guid EmployeeId { get; set; }

        public Guid TeamId { get; set; }

        public DateTime JoinDate { get; set; }
    }
}
