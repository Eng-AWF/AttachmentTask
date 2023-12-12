using EmployeeAttachment.Application.Persistence;
using EmployeeAttachment.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttachment.Infrastructure
{
    public static class DependencyInstaller
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAttachmentRepository, AttachmentRepository>();
            return services;
        }
    }
}
