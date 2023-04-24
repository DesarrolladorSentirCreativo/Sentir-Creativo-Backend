using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Bitacoras.Controllers;
using Sentir_Creativo_Backend.Bitacoras.Presenters;
using Sentir_Creativo_Backend.Bitacoras.UseCases;

namespace Sentir_Creativo_Backend.Bitacoras.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddBitacorasServices(this IServiceCollection services)
    {
        services.AddBitacorasUseCasesServices();
        services.AddBitacorasControllers();
        services.AddBitacorasPresenters();

        return services;
    }
}