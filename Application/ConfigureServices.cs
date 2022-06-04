using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ValtikCA.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //Esta linea registra automáticamente todos  los validadores de Fluent Validation
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            //Esta linea regitra automaticamente todos los mapping del automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
