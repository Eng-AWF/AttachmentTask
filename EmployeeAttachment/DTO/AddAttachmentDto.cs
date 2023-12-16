namespace EmployeeAttachment.API.DTO
{
    public class AddAttachmentDto
    {
        public string? FileName { get; set; }
        public string? Description { get; set; }
        //public byte[]? FileData { get; set; }
        public Guid? EmployeeId { get; set; }
       
    }

    public class FileUploadDTO
    {
        public Guid EmployeeId { get; set; }
        public List<MyFileDTO> Files { get; set; } = new List<MyFileDTO>();
    }

    public class MyFileDTO
    {
        public string FileName { get; set; }
        public string Description { get; set; }
        public FormFile File { get; set; }
    }
}
