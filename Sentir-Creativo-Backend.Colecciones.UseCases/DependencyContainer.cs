using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Ports.Colecciones.Select;
using Sentir_Creativo_Backend.Colecciones.UseCases.Colecciones.Select;

namespace Sentir_Creativo_Backend.Colecciones.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddColeccionesUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ISelectColeccionInputPort, SelectColeccionInteractor>();

        return services;
    }
}