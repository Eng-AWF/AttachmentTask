using EmployeeAttachment.Application.Features.Attachment.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAttachment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AttachmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost ("AddAttachment")]
        public async Task<IActionResult> AddAttachment(List<AddAttachmentCommand> addAttachmentCommand)
        {
            foreach (var command in addAttachmentCommand)
            {
                await _mediator.Send(command);
            }
          
            return Ok();
        }
    }
}
