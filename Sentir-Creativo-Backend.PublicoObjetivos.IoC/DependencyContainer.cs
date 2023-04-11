using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.PublicoObjetivos.Controllers;
using Sentir_Creativo_Backend.PublicoObjetivos.Presenters;
using Sentir_Creativo_Backend.PublicoObjetivos.UseCases;

namespace Sentir_Creativo_Backend.PublicoObjetivos.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddPublicoObjetivosServices(this IServiceCollection services)
    {
        services.AddPublicoObjetivosUseCasesServices();
        services.AddPublicoObjetivosPresenters();
        services.AddPublicoObjetivosControllers();
        
        return services;
    }
}