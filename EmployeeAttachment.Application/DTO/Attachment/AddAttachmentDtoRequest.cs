using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Application.DTO.Attachment
{
    public record AddAttachmentDtoRequest(Guid? Id, string fileName, string description, byte[] fileData, Guid employeeId);
    
}
