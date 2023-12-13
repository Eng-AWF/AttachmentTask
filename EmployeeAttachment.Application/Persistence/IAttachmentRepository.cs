using EmployeeAttachment.Application.Features.Attachment.Commands.AddAttachment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Application.Persistence
{
    public interface IAttachmentRepository
    {
        Task<bool> AddAttachment(AddAttachmentCommand addAttachmentCommand);
    }
}
