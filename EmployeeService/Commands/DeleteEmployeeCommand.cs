using CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Commands
{
    public class DeleteEmployeeCommand : CommandBase
    {
        public Guid EmployeeId { get; set; }
    }
}
