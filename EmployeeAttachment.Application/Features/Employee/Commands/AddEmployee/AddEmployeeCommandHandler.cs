using EmployeeAttachment.Domain.Entities;
using EmployeeAttachment.Infrastructure.DataAccess;
using EmployeeAttachment.Infrastructure.Services;
using MediatR;

namespace EmployeeAttachment.Application.Features.Employee.Commands.AddEmployee
{
    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand>
    {
        public readonly ApplicationDbContext _applicationDbContext;

        public readonly IFileService fileService;


        public AddEmployeeCommandHandler(ApplicationDbContext applicationDbContext, IFileService fileService)
        {
            _applicationDbContext = applicationDbContext;
            this.fileService = fileService;
        }



        public async Task Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {

            var fileName = await fileService.SaveFile(request.Image);

            var employee = new Domain.Entities.Employee(

                request.FirstName,
                request.LastName,
                request.Email,
                fileName,
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
