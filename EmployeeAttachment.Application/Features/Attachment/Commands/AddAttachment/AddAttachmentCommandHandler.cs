using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
