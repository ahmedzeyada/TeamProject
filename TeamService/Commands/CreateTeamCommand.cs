using CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamService.Commands
{
    public class CreateTeamCommand : CommandBase
    {
        public string Name { get; set; }
    }
}
