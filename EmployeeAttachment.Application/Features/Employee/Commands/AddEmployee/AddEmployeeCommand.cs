using EmployeeAttachment.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace EmployeeAttachment.Application.Features.Employee.Commands.AddEmployee
{
    public class AddEmployeeCommand : IRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public IFormFile? Image { get; set; }
        public int? Salary { get; set; }
        public string? Phone { get; set; }
        public string? FullName { get; set; }
        public DateTime HireDate { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }

    }
}