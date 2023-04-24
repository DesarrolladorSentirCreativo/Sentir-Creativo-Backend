using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Controllers.Bitacoras;
using Sentir_Creativo_Backend.Bitacoras.Controllers.Bitacoras;

namespace Sentir_Creativo_Backend.Bitacoras.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddBitacorasControllers(this IServiceCollection services)
    {
        services.AddScoped<ICreateBitacoraController, CreateBitacoraController>();
        
        return services;
    }
}