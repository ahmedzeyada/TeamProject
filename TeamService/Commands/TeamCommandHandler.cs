using CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamService.Commands
{
    public class TeamCommandHandler :
        ICommandHandler<CreateTeamCommand>,
        ICommandHandler<AddTeamEmployeeCommand>
    {

        IEventPublisher _publisher;

        public TeamCommandHandler(IEventPublisher eventPublisher)
        {
            _publisher = eventPublisher;
        }

        public async Task<object> Execute(AddTeamEmployeeCommand command)
        {
            await Task.Delay(1000);
            return null;
        }
        public async Task<object> Execute(CreateTeamCommand command)
        {
            await Task.Delay(1000);
            return null;
        }
    }
}
