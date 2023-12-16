using EmployeeAttachment.Application.Features.Employee.Commands.AddEmployee;
using EmployeeAttachment.Application.Features.Employee.Commands.DeleteEmployee;
using EmployeeAttachment.Application.Features.Employee.Commands.UpdateEmployee;
using EmployeeAttachment.Application.Features.Employee.Queries.GetAllEmployee;
using EmployeeAttachment.Application.Features.Employee.Queries.GetEmployeeInfoById;
using EmployeeAttachment.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAttachment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IMediator _mediator { get; }

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpPost("Add")]
        public async Task<IActionResult> AddEmployee(AddEmployeeCommand addEmployeeCommand)
        {
            await _mediator.Send(addEmployeeCommand);
            return Ok();
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllEmployee()
        {
            var result = await _mediator.Send(new GetAllEmployeeQuery());
            return Ok(result);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetEmployeeById(string id)
        {
            var result = await _mediator.Send(new GetEmployeeInfoByIdQuery() { EmployeeId = new Guid(id) });

            return Ok(result);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteEmployee(string id)
        {
            await _mediator.Send(new DeleteEmployeeCommand(id));
            return Ok();
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployeeCommand updateEmployeeCommand)
        {
            await _mediator.Send(updateEmployeeCommand);
            return Ok();
        }


    }
}
