using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Controllers.PublicoObjetivos;
using Sentir_Creativo_Backend.PublicoObjetivos.Controllers.PublicoObjetivos;

namespace Sentir_Creativo_Backend.PublicoObjetivos.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddPublicoObjetivosControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectPublicoObjetivoController, SelectPublicoObjetivoController>();
        
        return services;
    }
}