using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Servicios.Controllers;
using Sentir_Creativo_Backend.Servicios.Presenters;
using Sentir_Creativo_Backend.Servicios.UseCases;

namespace Sentir_Creativo_Backend.Servicios.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddServiciosServices(this IServiceCollection services)
    {
        services.AddServiciosUseCasesServices();
        services.AddServiciosPresenters();
        services.AddServiciosControllers();
        
        return services;
    }
}