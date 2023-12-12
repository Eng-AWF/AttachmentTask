using EmployeeAttachment.Application.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Application.Features.Attachment.Commands
{
    public class AddAttachmentCommandHandler : IRequestHandler<AddAttachmentCommand,bool>
    {
        private readonly IAttachmentRepository _attachmentRepository;
        public AddAttachmentCommandHandler(IAttachmentRepository attachmentRepository)
        {
            _attachmentRepository = attachmentRepository;
        }
        public async Task<bool> Handle(AddAttachmentCommand request, CancellationToken cancellationToken)
        {
            var result = await _attachmentRepository.AddAttachment(request);

            return true;
        }
    }
}
