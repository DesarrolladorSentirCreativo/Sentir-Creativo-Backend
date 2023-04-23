using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.CuponesDescuentos.Controllers;
using Sentir_Creativo_Backend.CuponesDescuentos.Presenters;
using Sentir_Creativo_Backend.CuponesDescuentos.UseCases;

namespace Sentir_Creativo_Backend.CuponesDescuentos.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddCuponesDescuentosServices(this IServiceCollection services)
    {
        services.AddCuponesDescuentosUseCasesService();
        services.AddCuponesDescuentosPresenters();
        services.AddCuponesDescuentosControllers();
        
        return services;
    }
}