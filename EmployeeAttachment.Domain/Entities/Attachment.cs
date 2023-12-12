using EmployeeAttachment.Domain.Primitives;

namespace EmployeeAttachment.Domain.Entities
{
    public class Attachment : BaseEntity
    {
        public string? FileName { get; private set; }
        public string? Description { get; private set; }
        public byte[]? FileData { get; private set; }

        public Guid? EmployeeId { get; private set; }
        public Employee? Employee { get; private set; }

        private Attachment()
        { }

        public Attachment(string fileName, string description, byte[] fileData, Guid employeeId)
        {
            FileName = fileName;
            Description = description;
            FileData = fileData;
            EmployeeId = employeeId;
        }
    }
}