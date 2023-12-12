using EmployeeAttachment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Infrastructure.DataAccess.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .ToTable(nameof(Employee));

            builder
                .HasKey(e => e.Id);

            builder
                .OwnsOne(d => d.Address);

            //builder.HasData(new Employee("Awf", "Alhalaybeh", "Awf@gmail.com", "", 500, "0770612989", "Awf Alhalaybeh",
            //    DateTime.UtcNow, new Address("Amman", "Jordan")

            //    ));

           
        }
    }
}
