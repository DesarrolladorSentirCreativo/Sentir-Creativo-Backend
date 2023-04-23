using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Controllers;
using Sentir_Creativo_Backend.CuponesDescuentos.Controllers.CuponesDescuentos;

namespace Sentir_Creativo_Backend.CuponesDescuentos.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddCuponesDescuentosControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectCuponDescuentoController, SelectCuponDescuentoController>();
        
        return services;
    }
}