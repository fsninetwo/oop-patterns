﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Providers;
using OOP_Patterns.Services.Services.Factory;

namespace OOP_Patterns.API.Extensions
{
    static class ServiceExtensions
    {
        public static void AddDependencyInjections(this IServiceCollection services)
        {
            services.AddScoped<IUploadService, UploadService>();
            services.AddScoped<IUploadProvider, UploadProvider>();

            services.AddScoped<IBaseUploadService, TCPUploadService>();
            services.AddScoped<IBaseUploadService, UDPUploadService>();
        }

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
