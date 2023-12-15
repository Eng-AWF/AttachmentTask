using EmployeeAttachment.Application.Features.Employee.Commands.AddEmployee;
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


    }
}
