using CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamService.Commands
{
    public class AddTeamEmployeeCommand : CommandBase
    {
        public Guid EmployeeId { get; set; }
        public Guid TeamId { get; set; }

    }
}
