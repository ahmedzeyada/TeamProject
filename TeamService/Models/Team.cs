using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamService.Models
{
    public class Team
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<TeamEmployee> Employees;
    }
}
