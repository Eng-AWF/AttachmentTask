using EmployeeAttachment.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAttachment.API.Extensions
{
    public static class DbContextExtension
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetValue<string>("ConnectionString"))
            );
            return services;

        }
    }
}
