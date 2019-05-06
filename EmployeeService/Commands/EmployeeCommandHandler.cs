using CQRS;
using EmployeeService.Commands;
using EmployeeService.Models;
using NoSqlEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Commands
{
    public class EmployeeCommandHandler : 
        ICommandHandler<CreateEmployeeCommand>,
        ICommandHandler<DeleteEmployeeCommand>
    {
        IEventPublisher _publisher;

        public EmployeeCommandHandler(IEventPublisher eventPublisher)
        {
            _publisher = eventPublisher;
        }

        public async Task<object> Execute(CreateEmployeeCommand command)
        {
            await NoSqlProcessor.CreateEntry(new Employee()
            {
                FirstName= command.FirstName,
                SecondName = command.SecondName,
                LastName = command.LastName,
            });
            return "10";
        }

        public async Task<object> Execute(DeleteEmployeeCommand command)
        {
            await Task.Delay(1000);
            return null;
        }
    }
}
