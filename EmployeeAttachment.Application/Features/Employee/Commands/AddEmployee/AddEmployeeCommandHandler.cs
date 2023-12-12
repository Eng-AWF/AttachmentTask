using MediatR;

namespace EmployeeAttachment.Application.Features.Employee.Commands.AddEmployee
{
    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand>
    {

        public Task<Unit> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
