using EmployeeAttachment.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Infrastructure.Services
{
    public class FileService : IFileService
    {
        //public int OneMBSize = 1024 * 1024;

        /*
         
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), $@"wwwroot\EmployeesFiles\{employeeId}");
         */


        public string _fielsFolder = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Images");


        public async Task<string> SaveFile(IFormFile file)
        {
            var fileName = GenerateFileName(file.FileName);

            Directory.CreateDirectory(_fielsFolder);

            var path = Path.Combine(_fielsFolder, fileName);

            //Saving the picture in the images folder
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return fileName;
        }

        private string GenerateFileName(string fileName)
        {
            var ext = Path.GetExtension(fileName);
            var randomName = Guid.NewGuid().ToString();
            return randomName + ext;
        }

    }
}
