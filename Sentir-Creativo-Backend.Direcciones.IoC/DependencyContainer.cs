using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Direcciones.Controllers;
using Sentir_Creativo_Backend.Direcciones.Presenters;
using Sentir_Creativo_Backend.Direcciones.UseCases;

namespace Sentir_Creativo_Backend.Direcciones.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddDireccionesServices(this IServiceCollection services)
    {
        services.AddDireccionesUseCasesServices();
        services.AddDireccionesControllers();
        services.AddDireccionesPresenters();

        return services;
    }
}