using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.Controllers;
using Sentir_Creativo_Backend.Difusiones.Controllers.Difusiones;

namespace Sentir_Creativo_Backend.Difusiones.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddDifusionesControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectDifusionController, SelectDifusionController>();
        
        return services;
    }
}