using EmployeeAttachment.Infrastructure.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Application.Features.Employee.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
    {
        public readonly ApplicationDbContext _applicationDbContext;
        public UpdateEmployeeCommandHandler(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _applicationDbContext.employees
                .FirstOrDefault(e => e.Id == request.Id);

            if (employee == null)
            {
                throw new Exception("employee not found");
            }

            employee.UpdateEmployee(request.FirstName, request.LastName, request.Email,request.Image,request.Salary,request.Phone,request.HireDate,request.FullName,request.Country,request.City);

            _applicationDbContext.employees.Update(employee);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
