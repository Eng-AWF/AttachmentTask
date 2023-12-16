using EmployeeAttachment.API.DTO;
using EmployeeAttachment.Application.Features.Attachment.Commands.AddAttachment;
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
        public async Task<IActionResult> AddAttachment(AddAttachmentDto addAttachmentDto)
        {
            
            return Ok();
        }

        [HttpPost("AddAttachment2")]
        public IActionResult UploadFiles( FileUploadDTO fileUploadDTO)
        {
            try
            {
                // Access file information and other properties in fileUploadDTO
                Guid employeeId = fileUploadDTO.EmployeeId;
                List<MyFileDTO> files = fileUploadDTO.Files;

                // Process files as needed
                foreach (var file in files)
                {
                    // Access file properties
                    string fileName = file.FileName;
                    string description = file.Description;

                    // Access file stream
                    IFormFile fileData = file.File;
                    using (var stream = fileData.OpenReadStream())
                    {
                        // Save or process the file stream as needed
                        // For demonstration purposes, we'll print the file information
                        Console.WriteLine($"EmployeeId: {employeeId}, FileName: {fileName}, Description: {description}");
                    }
                }

                return Ok(new { Message = "Files uploaded successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = $"Error uploading files: {ex.Message}" });
            }
        }
    }
}
