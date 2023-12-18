using EmployeeAttachment.Domain.Entities;
using EmployeeAttachment.Infrastructure.DataAccess;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAttachment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IWebHostEnvironment _appEnvironment;

        public AttachmentController(IMediator mediator, ApplicationDbContext applicationDbContext, IWebHostEnvironment appEnvironment)
        {
            _mediator = mediator;
            _applicationDbContext = applicationDbContext;
            _appEnvironment = appEnvironment;
        }

        [HttpGet("GetAttachment/{employeeId}")]
        public async Task<IActionResult> GetAttachments(Guid employeeId)
        {
            var result = await _applicationDbContext.attachments
                .Where(a => a.EmployeeId == employeeId)
                .ToListAsync();
            return Ok(result);
        }

        [HttpPost("AddAttachment/{employeeId}")]
        public async Task<IActionResult> AddAttachment(Guid employeeId, List<IFormFile> files)
        {
            //if (files.Count > 0)
            //{
            //    var employeeFilePath = CreateNewEmployeeFolder(employeeId);
            //    return Ok(await CopyFilesToEmployeeFile(files, employeeId, employeeFilePath));
            //}
            //return Ok();

            
                if (files.Count > 0)
                {
                    var employeeFilePath = CreateNewEmployeeFolder(employeeId);
                    var validFiles = new List<IFormFile>();

                    foreach (var file in files)
                    {
                        if (file.Length <= 1024 * 1024) // 2 MB (2 * 1024 * 1024 bytes)
                        {
                            validFiles.Add(file);
                        }
                    }

                    if (validFiles.Count > 0)
                    {
                        return Ok(await CopyFilesToEmployeeFile(validFiles, employeeId, employeeFilePath));
                    }
                    else
                    {
                        return BadRequest("File size exceeds the maximum allowed limit (2 MB).");
                    }
                }

                return Ok();
            
        }

        private string CreateNewEmployeeFolder(Guid employeeId)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), $@"wwwroot\EmployeeAttachments\{employeeId}");
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            return filePath;
        }

        private async Task<List<Attachment>> CopyFilesToEmployeeFile(List<IFormFile> files, Guid employeeId, string employeeFilePath)
        {
            var entityList = new List<Attachment>();
            foreach (var file in files)
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), $@"wwwroot\EmployeeAttachments\{employeeId}\{file.FileName}");

                using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
                var fileEntity = new Attachment();
                fileEntity.FileName = file.FileName;
                fileEntity.EmployeeId = employeeId;
                fileEntity.FilePath = $@"EmployeeAttachments\{employeeId}\{file.FileName}";
                fileEntity.UploadDate = DateTime.Now;
                entityList.Add(fileEntity);
            }
            _applicationDbContext.AddRange(entityList);
            await _applicationDbContext.SaveChangesAsync();
            return entityList;
        }
    }
}