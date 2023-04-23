using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Difusiones.Controllers;
using Sentir_Creativo_Backend.Difusiones.Presenters;
using Sentir_Creativo_Backend.Difusiones.UseCases;

namespace Sentir_Creativo_Backend.Difusiones.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddDifusionesServices(this IServiceCollection services)
    {
        services.AddDifusionesUseCasesService();
        services.AddDifusionesPresenters();
        services.AddDifusionesControllers();
        
        return services;
    }
}