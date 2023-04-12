using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Controllers.Colecciones;
using Sentir_Creativo_Backend.Colecciones.Controllers.Colecciones;

namespace Sentir_Creativo_Backend.Colecciones.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddColeccionesControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectColeccionController, SelectColeccionController>();

        return services;
    }
}