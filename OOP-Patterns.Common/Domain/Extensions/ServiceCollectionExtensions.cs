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
        public static IServiceCollection 
            AddChained<TService>(this IServiceCollection services, params Type[] implementations)
                where TService : class
        {
            if(implementations is null || !implementations.Any())
            {
                throw new ArgumentNullException("Insert at least one of implementation type", nameof(implementations)); 
            }

            foreach(var implementation in implementations) 
            {
                services.AddScoped(implementation);
            }

            var order = 0;
            services.AddTransient(typeof(TService), provider =>
            {
                if(order > implementations.Length - 1)
                {
                    order = 0;
                }

                var type = implementations[order];
                order++;

                return provider.GetService(type);
            });

            return services;
        }

        public static IServiceCollection 
            AddDecorator<TService, TDecorator>(this IServiceCollection services, 
                Action<IServiceCollection> configureDecorateeServices)
                where TService : class
                where TDecorator : class, TService
        {
            var decorateeServices = new ServiceCollection();

            configureDecorateeServices(decorateeServices);

            var decorateeDescriptor =
                decorateeServices.SingleOrDefault(sd => sd.ServiceType == typeof(TService));

            if (decorateeDescriptor == null)
            {
                throw new InvalidOperationException("No decoratee configured!");
            }

            decorateeServices.Remove(decorateeDescriptor);

            services.Add(decorateeServices);

            var decoratorInstanceFactory = ActivatorUtilities.CreateFactory(
                typeof(TDecorator), new[] { typeof(TService) });

            Type decorateeImplType = decorateeDescriptor.GetImplementationType();

            Func<IServiceProvider, TDecorator> decoratorFactory = sp =>
            {
                var decoratee = sp.GetRequiredService(decorateeImplType);
                var decorator = (TDecorator)decoratorInstanceFactory(sp, new[] { decoratee });

                return decorator;
            };

            var decoratorDescriptor = ServiceDescriptor.Describe(
                typeof(TService),
                decoratorFactory,
                decorateeDescriptor.Lifetime);

            decorateeDescriptor = RefactorDecorateeDescriptor(decorateeDescriptor);

            services.Add(decorateeDescriptor);
            services.Add(decoratorDescriptor);

            return services;
        }

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

        private static ServiceDescriptor RefactorDecorateeDescriptor(ServiceDescriptor decorateeDescriptor)
        {
            var decorateeImplType = decorateeDescriptor.GetImplementationType();

            if (decorateeDescriptor.ImplementationFactory != null)
            {
                decorateeDescriptor =
                    ServiceDescriptor.Describe(
                        decorateeImplType,
                        decorateeDescriptor.ImplementationFactory,
                        decorateeDescriptor.Lifetime);
            }
            else
            if (decorateeDescriptor.ImplementationInstance != null)
            {
                decorateeDescriptor =
                    ServiceDescriptor.Singleton(
                        decorateeImplType, 
                        decorateeDescriptor.ImplementationInstance);
            }
            else
            {
                decorateeDescriptor =
                    ServiceDescriptor.Describe(
                    decorateeImplType, // Yes, use the same type for both.
                    decorateeImplType,
                    decorateeDescriptor.Lifetime);
            }

            return decorateeDescriptor;
        }

        private static Type GetImplementationType(this ServiceDescriptor serviceDescriptor)
        {
            if (serviceDescriptor.ImplementationType != null)
                return serviceDescriptor.ImplementationType;

            if (serviceDescriptor.ImplementationInstance != null)
                return serviceDescriptor.ImplementationInstance.GetType();

            if (serviceDescriptor.ImplementationFactory != null)
                return serviceDescriptor.ImplementationFactory.GetType().GenericTypeArguments[1];

            throw new InvalidOperationException("No way to get the decoratee implementation type.");
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
