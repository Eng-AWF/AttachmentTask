using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Application.Features.Employee.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommand : IRequest
    {
        public Guid EmployeeId { get; private set; }

        public DeleteEmployeeCommand(string employeeId)
        {
            EmployeeId = new Guid(employeeId);
        }
    }
}
