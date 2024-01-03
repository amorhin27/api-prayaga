using ApiPrayaga.Application.Interfaces.Repository.ICarrera;
using ApiPrayaga.Application.Interfaces.Repository.IFacultad;
using ApiPrayaga.Infrastructure.Repositories.CarerraRepo;
using ApiPrayaga.Infrastructure.Repositories.FacultadRepo;
using ApiPrayaga.Infrastucture.Connections.ContextData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPrayaga.Infrastucture
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var cnn = configuration.GetConnectionString("CadenaSQL");
            services.AddDbContext<PrayagaDbContext>(options => options.UseSqlServer(cnn));

            services.AddScoped<IGetAllFacultadRepository, GetAllFacultadRepository>();
            services.AddScoped<ICreateFacultadRepository, CreateFacultadRepository>();

            services.AddScoped<IGetAllCarreraRepository, GetAllCarreraRepository>();
            services.AddScoped<ICreateCarreraRepository, CreateCarreraRepository>();


            return services;
        }
    }
}
