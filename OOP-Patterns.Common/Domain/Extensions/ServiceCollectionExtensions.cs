using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddFactory<TService, TImplementation>(this IServiceCollection services)
            where TService : class
            where TImplementation : class, TService
        {
            if(services == null) 
            {
                throw new ArgumentNullException(nameof(services)); 
            }

            services
                .AddScoped<TImplementation>()
                .AddScoped<TService, TImplementation>(x => 
                    x.GetService<TImplementation>());

            services.TryAddScoped<IFactory<TService>, Factory<TService>>();

            return services;
        }
    }

    public class Factory<TService> : IFactory<TService>
    {
        private readonly IServiceProvider _serviceProvider;

        public Factory(IServiceProvider serviceProvider) 
        {
            _serviceProvider = serviceProvider;
        }

        public TService Create<TImplementation>() 
            where TImplementation : class, TService
        {
            var requiredService = 
                _serviceProvider.GetRequiredService<TImplementation>();

            return requiredService;
        }
    }

    public interface IFactory<T>
    {
        public T Create<TImplementation>()
            where TImplementation : class, T;
    }
}
