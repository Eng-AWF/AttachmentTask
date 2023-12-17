
using EmployeeAttachment.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;


namespace EmployeeAttachment.Infrastructure
{
    public static class DependencyInstaller
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IFileService, FileService>();
            return services;
        }
    }
}
