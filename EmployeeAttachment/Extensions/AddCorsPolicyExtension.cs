namespace EmployeeAttachment.API.Extensions
{
    public static class AddCorsPolicyExtension
    {
        public static IServiceCollection AddCrosPolicyEx(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: "crossOrigin",
                                  builder =>
                                  {
                                      builder.AllowAnyOrigin(); //the local host
                                      builder.AllowAnyHeader(); // any header
                                      builder.AllowAnyMethod(); //get,post,....
                                  });
            });

            return services;
        }
    }
}
