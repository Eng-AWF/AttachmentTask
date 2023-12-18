using MediatR;

namespace EmployeeAttachment.Application.Features.Attachment.Commands.AddAttachment
{
    public class AddAttachmentCommandHandler : IRequestHandler<AddAttachmentCommand, bool>
    {
        public async Task<bool> Handle(AddAttachmentCommand request, CancellationToken cancellationToken)
        {
            return true;
        }
    }
}