using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Application.Features.Employee.Queries.GetEmployeeInfoById
{
    public class GetEmployeeInfoByIdQuery : IRequest<GetEmployeeInfoByIdResponseDto>
    {
        public Guid EmployeeId { get; set; }

    }
}
