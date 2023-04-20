using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using OOP_Patterns.API.Handlers;
using OOP_Patterns.API.Handlers.Interfaces;
using OOP_Patterns.Common.Domain.Extensions;
using OOP_Patterns.Common.Domain.Interfaces;
using OOP_Patterns.Common.Domain.Providers;
using OOP_Patterns.Services.Adapters;
using OOP_Patterns.Services.Adapters.Interfaces;
using OOP_Patterns.Services.Handlers;
using OOP_Patterns.Services.Handlers.Interfaces;
using OOP_Patterns.Services.IServices;
using OOP_Patterns.Services.Providers;
using OOP_Patterns.Services.Services.AbstractFactory;
using OOP_Patterns.Services.Services.Adapter;
using OOP_Patterns.Services.Services.Bridge;
using OOP_Patterns.Services.Services.Builder;
using OOP_Patterns.Services.Services.ChainOfResponsibility;
using OOP_Patterns.Services.Services.Composite;
using OOP_Patterns.Services.Services.Decorator;
using OOP_Patterns.Services.Services.Facade;
using OOP_Patterns.Services.Services.Factory;
using OOP_Patterns.Services.Services.Flyweight;
using OOP_Patterns.Services.Services.Iterator;
using OOP_Patterns.Services.Services.Proxy;
using OOP_Patterns.Services.Services.Singleton;

namespace OOP_Patterns.API.Extensions
{
    static class ServiceExtensions
    {
        public static void AddDependencyInjections(this IServiceCollection services)
        {
            services.AddScoped<IUploadProvider, UploadProvider>();
            services.AddScoped<ICacheProvider, CacheProvider>();

            services.AddScoped<IEndpointAdapter, EndpointAdapter>();
            services.AddScoped<ICacheAdapter, CacheAdapter>();

            services.AddScoped<IUploadService, UploadService>();
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<ISingletonService, SingletonService>();
            services.AddScoped<IFileSystemService, FileSystemService>();
            services.AddScoped<IFlyweightService, FlyweightService>();
            services.AddScoped<IFacadeService, FacadeService>();
            services.AddScoped<INotifierService, NotifierService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IMessageProxyService, MessageProxyService>();
            services.AddScoped<IEndpointService, EndpointService>();
            services.AddScoped<IIteratorService, IteratorService>();
            
            services.AddScoped<IMessageHandlerService, MessageHandlerService>();
            services.AddChained<IMessageHandler>(typeof(UploadMessageHandler));

            services.AddDecorator<
                ISimpleService, SimpleServiceLoggingDecorator>(services => 
                services.AddScoped<ISimpleService, SimpleService>());

            services.AddScoped<IMessageCommandHandler, MessageCommandHandler>();

            services.AddFactory<IBaseUploadService, TCPUploadService>();
            services.AddFactory<IBaseUploadService, UDPUploadService>();
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
