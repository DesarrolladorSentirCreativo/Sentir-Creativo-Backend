using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Ports.Bitacoras.Create;
using Sentir_Creativo_Backend.Bitacoras.UseCases.Bitacoras.Create;

namespace Sentir_Creativo_Backend.Bitacoras.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddBitacorasUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ICreateBitacoraInputPort, CreateBitacoraInteractor>();
        
        return services;
    }
}