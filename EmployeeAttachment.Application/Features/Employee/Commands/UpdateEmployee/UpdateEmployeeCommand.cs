using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Application.Features.Employee.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommand : IRequest
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Image { get; set; }
        public int? Salary { get; set; }
        public string? Phone { get; set; }
        public string? FullName { get; set; }
        public DateTime HireDate { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
