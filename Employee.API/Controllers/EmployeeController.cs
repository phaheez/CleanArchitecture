using Employee.Application.Commands;
using Employee.Application.Queries;
using Employee.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator) => _mediator = mediator;

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<EmployeeResponse>> CreateEmployee([FromBody] CreateEmployeeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Core.Entities.Employee>> GetEmployees()
        {
            return await _mediator.Send(new GetAllEmployeeQuery());
        }

        [HttpGet("{id:int}", Name = "GetEmployeeById")]
        public async Task<ActionResult<Core.Entities.Employee>> GetEmployeeById(int id)
        {
            var employee = await _mediator.Send(new GetEmployeeByIdQuery(id));
            return employee != null ? Ok(employee) : NotFound(new { message = "Employee record not found!" });
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateEmployee([FromRoute] int id, [FromBody] UpdateEmployeeCommand command)
        {
            if(id != command.EmployeeId) return BadRequest();

            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteEmployee([FromRoute] int id)
        {
            return Ok(await _mediator.Send(new DeleteEmployeeCommand(id)));
        }
    }
}
