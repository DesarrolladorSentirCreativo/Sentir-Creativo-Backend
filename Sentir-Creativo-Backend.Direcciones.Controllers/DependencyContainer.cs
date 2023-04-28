using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Paises;
using Sentir_Creativo_Backend.Direcciones.Controllers.Paises;

namespace Sentir_Creativo_Backend.Direcciones.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddDireccionesControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectPaisController, SelectPaisController>();
        
        return services;
    }
}