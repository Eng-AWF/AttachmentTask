using EmployeeAttachment.Application.Features.Attachment.Commands.AddAttachment;
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
    public class AttachmentRepository : IAttachmentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AttachmentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<bool> AddAttachment(AddAttachmentCommand addAttachmentCommand)
        {
            var Attchement = new Attachment(addAttachmentCommand.FileName!,
                addAttachmentCommand.Description!,
                addAttachmentCommand.FileData!,
                addAttachmentCommand.UploadDate,
                new Guid("e0d61c17-d828-4966-8f5b-637f137e7443"));


            _applicationDbContext.attachments.Add(Attchement);

            await _applicationDbContext.SaveChangesAsync();

            return true;

        }
    }
}
