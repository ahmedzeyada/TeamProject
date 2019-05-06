using CQRS;
using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Commands
{
    public class CreateEmployeeCommand :  CommandBase
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        //public Employee ToEntity()
        //{
        //    return new Employee() { FirstName = FirstName, LastName = LastName, SecondName = SecondName };
        //}

    }
}
