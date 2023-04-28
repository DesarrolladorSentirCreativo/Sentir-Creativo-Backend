using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Paises.Select;
using Sentir_Creativo_Backend.Direcciones.UseCases.Paises.Select;

namespace Sentir_Creativo_Backend.Direcciones.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddDireccionesUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ISelectPaisInputPort, SelectPaisInteractor>();
        
        return services;
    }
}