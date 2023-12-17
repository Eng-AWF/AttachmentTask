using EmployeeAttachment.Application.Features.Employee.Commands.AddEmployee;
using EmployeeAttachment.Application.Features.Employee.Commands.DeleteEmployee;
using EmployeeAttachment.Application.Features.Employee.Commands.UpdateEmployee;
using EmployeeAttachment.Application.Features.Employee.Queries.GetAllEmployee;
using EmployeeAttachment.Application.Features.Employee.Queries.GetEmployeeInfoById;
using EmployeeAttachment.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> AddEmployee([FromForm] AddEmployeeCommand addEmployeeCommand)
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


        //[Route("uploadImage")]
        //[HttpPost]
        //public Employee UploadImage()
        //{
        //    var file = Request.Form.Files[0];
        //    var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
        //    var Pathimage = Path.Combine("Images", fileName);
        //    var fullPath = Path.Combine("Images", fileName);
        //    using (var stream = new FileStream(fullPath, FileMode.Create))
        //    {
        //        file.CopyTo(stream);
        //    }
        //    Employee item = new Employee();
        //    item.ImagePath = fileName;
        //    return item;
        //}

        //[HttpPost]
        //public IActionResult UploadImage(IFormFile imageFile)
        //{
        //    // Check if an image file was selected
        //    if (imageFile == null || imageFile.Length == 0)
        //    {
        //        // Handle error, no file selected
        //        return RedirectToAction("Index"); // Redirect to the appropriate action
        //    }

        //    // Generate a unique filename for the image (e.g., using Guid.NewGuid())
        //    string uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;

        //    // Get the path where you want to save the image
        //    string imagePath = Path.Combine(_hostingEnvironment.WebRootPath, "images", uniqueFileName);

        //    // Save the image file to the specified path
        //    using (var stream = new FileStream(imagePath, FileMode.Create))
        //    {
        //        imageFile.CopyTo(stream);
        //    }

        //    // Update the Employee entity with the image path
        //    // Assuming you have an instance of the Employee entity called 'employee'
        //    employee.ImagePath = uniqueFileName; // Save the filename or the full path, depending on your requirements

        //    // Save the updated entity to the database
        //    // Assuming you are using an ORM like Entity Framework Core
        //    _dbContext.SaveChanges();

        //    // Redirect to the appropriate action
        //    return RedirectToAction("Details", new { id = employee.Id });
        //}

         
    }

}

