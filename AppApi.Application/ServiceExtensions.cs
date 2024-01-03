using ApiPrayaga.Application.Behaviours;
using ApiPrayaga.Application.Globals;
using ApiPrayaga.Application.Interfaces.Repository.NLog;
using ApiPrayaga.Application.Interfaces.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using ApiPrayaga.Domain.Common;

namespace ApiPrayaga.Application
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            services.AddScoped<ILoggerManager, LoggerManager>();
            services.AddScoped<IOperacionesGenericos, ClaseGenerico>();

            return services;
        }
    }
}
