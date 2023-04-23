using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.Ports;
using Sentir_Creativo_Backend.Difusiones.UseCases.Difusiones.Select;

namespace Sentir_Creativo_Backend.Difusiones.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddDifusionesUseCasesService(this IServiceCollection services)
    {
        services.AddScoped<ISelectDifusionInputPort, SelectDifusionInteractor>();
        
        return services;
    }
}