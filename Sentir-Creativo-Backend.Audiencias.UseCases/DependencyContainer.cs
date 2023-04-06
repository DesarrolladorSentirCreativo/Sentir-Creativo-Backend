using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Origenes.SelectOrigen;
using Sentir_Creativo_Backend.Audiencias.UseCases.Origenes.Select;

namespace Sentir_Creativo_Backend.Audiencias.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddAudienciasUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ISelectOrigenInputPort, SelectOrigenInteractor>();
        
        return services;
    }
}