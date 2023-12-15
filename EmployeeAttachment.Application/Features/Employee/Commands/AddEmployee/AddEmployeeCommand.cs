using EmployeeAttachment.Domain.Entities;
using MediatR;

namespace EmployeeAttachment.Application.Features.Employee.Commands.AddEmployee
{
    public class AddEmployeeCommand : IRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Image { get; set; }
        public decimal? Salary { get; set; }
        public string? Phone { get; set; }
        public string? FullName { get; set; }
        public DateTime HireDate { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }

    }
}