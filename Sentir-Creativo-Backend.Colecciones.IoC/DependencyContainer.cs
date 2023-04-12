using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Colecciones.Controllers;
using Sentir_Creativo_Backend.Colecciones.Presenters;
using Sentir_Creativo_Backend.Colecciones.UseCases;

namespace Sentir_Creativo_Backend.Colecciones.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddColeccionesServices(this IServiceCollection services)
    {
        services.AddColeccionesUseCasesServices();
        services.AddColeccionesPresenters();
        services.AddColeccionesControllers();
        
        return services;
    }
}