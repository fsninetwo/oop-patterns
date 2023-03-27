using Microsoft.OpenApi.Models;

namespace OOP_Patterns.API.Extensions
{
    static class ServiceExtensions
    {
        public static void AddSwaggerService(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "OOP-Patterns.API", Version = "v1"});
            });
        }

        public static void UseSwaggerService(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => 
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "OOP-Patterns.API");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
