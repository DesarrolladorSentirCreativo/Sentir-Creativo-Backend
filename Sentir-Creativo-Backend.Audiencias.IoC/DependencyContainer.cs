using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Audiencias.Controllers;
using Sentir_Creativo_Backend.Audiencias.Presenters;
using Sentir_Creativo_Backend.Audiencias.UseCases;

namespace Sentir_Creativo_Backend.Audiencias.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddAudienciasServices(this IServiceCollection services)
    {
        services.AddAudienciasUseCasesServices();
        services.AddAudienciasControllers();
        services.AddAudienciasPresenters();
        
        return services;
    }
}