using EmployeeAttachment.Domain.Primitives;

namespace EmployeeAttachment.Domain.Entities
{
    public class Attachment : BaseEntity
    {
        public string? FileName { get;  set; }
        public string? Description { get;  set; }
        public string? FilePath { get;  set; }

        public DateTime? UploadDate { get;  set; } 

        public Guid? EmployeeId { get;  set; }
        public Employee? Employee { get;  set; }

        

        
    }
}