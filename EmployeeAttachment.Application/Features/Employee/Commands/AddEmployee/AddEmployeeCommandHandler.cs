using EmployeeAttachment.Domain.Entities;
using EmployeeAttachment.Infrastructure.DataAccess;
using MediatR;

namespace EmployeeAttachment.Application.Features.Employee.Commands.AddEmployee
{
    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand>
    {
        public readonly ApplicationDbContext _applicationDbContext;
        public AddEmployeeCommandHandler(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }



        public async Task Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Domain.Entities.Employee(

                request.FirstName,
                request.LastName,
                request.Email,
                request.Image,
                request.Salary,
                request.Phone,
                request.HireDate,
                request.FullName,
                request.Country,
                request.City

                );

            _applicationDbContext.employees.Add(employee);
            await _applicationDbContext.SaveChangesAsync();

        }
    }
}
