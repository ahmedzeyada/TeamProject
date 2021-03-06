﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS;
using EmployeeService.Commands;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromServices]ICommandHandler<CreateEmployeeCommand> handler, [FromBody] CreateEmployeeCommand command)
        {
             
            var id = await handler.Execute(command);
            return Ok(id);
        }
    }
}
