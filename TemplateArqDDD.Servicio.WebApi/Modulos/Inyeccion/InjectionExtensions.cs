using TemplateArqDDD.Aplicacion.Core;
using TemplateArqDDD.Aplicacion.Interface;
using TemplateArqDDD.Dominio.Core;
using TemplateArqDDD.Dominio.Interface;
using TemplateArqDDD.Infraestructura.Core;
using TemplateArqDDD.Infraestructura.Interface;
using TemplateArqDDD.Infrastructure.Data;
using TemplateArqDDD.Transversal.Common;

namespace TemplateArqDDD.Servicio.WebApi.Modulos.Inyeccion
{
    /// <summary>
    /// Indica todas las injecciones de dependencia hacia las interfaces
    /// </summary>
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPagadorApInterface, PagadorApCore>();
            services.AddScoped<IPagadorDoInterface, PagadorDoCore>();
            services.AddScoped<IPagadorInInterface, PagadorInCore>();

            services.AddSingleton<IConfiguration>(configuration);
            services.AddSingleton<IConnectionFactory, ConnectionFactory>();

            return services;
        }
    }
}

//System.InvalidOperationException: Unable to resolve service for type
//'TemplateArqDDD.Aplicacion.Interface.IPagadorApInterface' while attempting to activate 'TemplateArqDDD.Servicio.WebApi.Controllers.PagadorController'.