using EmployeeAttachment.Infrastructure.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Application.Features.Employee.Commands.DeleteEmployee
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand>
    {

        public readonly ApplicationDbContext _applicationDbContext;
        public DeleteEmployeeCommandHandler(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _applicationDbContext.employees
                .FirstOrDefault(e => e.Id == request.EmployeeId);

            if (employee == null)
            {
                throw new Exception("employee not found");
            }

            _applicationDbContext.employees.Remove(employee);

            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
