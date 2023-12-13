using EmployeeAttachment.Application.Features.Employee.Commands.AddEmployee;
using EmployeeAttachment.Application.Persistence;
using EmployeeAttachment.Domain.Entities;
using EmployeeAttachment.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EmployeeRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //public async Task<bool> AddEmployee(AddEmployeeCommand addEmployeeCommand)
        //{
        //    var Employee = new Employee(
        //        addEmployeeCommand.FirstName,
        //        addEmployeeCommand.LastName,
        //        addEmployeeCommand.Email,
        //        addEmployeeCommand.Image,

        //        addEmployeeCommand.Phone,
        //        addEmployeeCommand.FullName,
        //        addEmployeeCommand.HireDate,



        //        );
        //}
    }
}
