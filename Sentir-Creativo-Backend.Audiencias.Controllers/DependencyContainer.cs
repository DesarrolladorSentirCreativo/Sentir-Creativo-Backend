using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Origenes;
using Sentir_Creativo_Backend.Audiencias.Controllers.Origenes;

namespace Sentir_Creativo_Backend.Audiencias.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddAudienciasControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectOrigenController, SelectOrigenController>();
        
        return services;
    }
}