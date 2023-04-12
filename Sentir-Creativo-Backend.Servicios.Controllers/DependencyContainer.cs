using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Formatos;
using Sentir_Creativo_Backend.Servicios.Controllers.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.Controllers.Formatos;

namespace Sentir_Creativo_Backend.Servicios.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddServiciosControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectEstadoServicioController, SelectEstadoServicioController>();
        services.AddScoped<ISelectFormatoController, SelectFormatoController>();
        
        return services;
    }
}