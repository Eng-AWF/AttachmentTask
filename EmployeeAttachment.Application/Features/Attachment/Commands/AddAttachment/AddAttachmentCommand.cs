using MediatR;

namespace EmployeeAttachment.Application.Features.Attachment.Commands.AddAttachment
{
    public class AddAttachmentCommand : IRequest<bool>
    {
        public string? FileName { get; set; }
        public string? Description { get; set; }
        public byte[]? FileData { get; set; }

        // public DateTime UploadDate { get; set; } = DateTime.UtcNow;
        public Guid? EmployeeId { get; set; }

        //public EmployeeAttachment.Domain.Entities.Employee? Employee { get;  set; }
    }
}