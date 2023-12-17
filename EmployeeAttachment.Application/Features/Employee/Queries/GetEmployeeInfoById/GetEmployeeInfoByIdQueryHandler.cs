using EmployeeAttachment.Application.Features.Employee.Queries.GetAllEmployee;
using EmployeeAttachment.Infrastructure.DataAccess;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Application.Features.Employee.Queries.GetEmployeeInfoById
{
    public class GetEmployeeInfoByIdQueryHandler : IRequestHandler<GetEmployeeInfoByIdQuery, GetEmployeeInfoByIdResponseDto>
    {
        public readonly ApplicationDbContext _applicationDbContext;
        public GetEmployeeInfoByIdQueryHandler(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<GetEmployeeInfoByIdResponseDto> Handle(GetEmployeeInfoByIdQuery request, CancellationToken cancellationToken)
        {
            var employee =await _applicationDbContext.employees
                .Where(e => e.Id == request.EmployeeId)
                .FirstOrDefaultAsync();

            if (employee == null) { return null; }

            var response = new GetEmployeeInfoByIdResponseDto();

            response.FirstName = employee.FirstName;
            response.LastName = employee.LastName;
            response.Email = employee.Email;
            response.ImagePath = employee.ImagePath;
            response.Salary = employee.Salary;
            response.Phone = employee.Phone;
            response.HireDate = employee.HireDate;
            response.FullName = employee.FullName;
            response.City = employee.City;
            response.Country = employee.Country;


            return response;
        }
    }
}
