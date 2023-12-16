using EmployeeAttachment.Infrastructure.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Application.Features.Employee.Queries.GetAllEmployee
{
    public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQuery, List<GetAllEmployeeResponeDto>>
    {
        public readonly ApplicationDbContext _applicationDbContext;
        public GetAllEmployeeQueryHandler(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Task<List<GetAllEmployeeResponeDto>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            var employeeList  =  _applicationDbContext.employees
                .Select(e => new GetAllEmployeeResponeDto()
                {
                    Id = e.Id,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Email = e.Email,
                    Image = e.Image,
                    Salary = e.Salary,
                    Phone = e.Phone,
                    FullName = e.FullName,
                    HireDate = e.HireDate,
                    City = e.City,
                    Country = e.Country,

                })
                .ToList();

            return Task.FromResult(employeeList);

           
        }
    }
}
