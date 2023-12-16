using EmployeeAttachment.Infrastructure.DataAccess;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Application.Features.Employee.Queries.GetAllEmployee
{
    public class GetAllEmployeeQuery : IRequest<List<GetAllEmployeeResponeDto>>
    {
       
    }
}
