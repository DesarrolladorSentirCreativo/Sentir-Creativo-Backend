using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Origenes.SelectOrigen;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Origenes;
using Sentir_Creativo_Backend.Audiencias.Presenters.Origenes;

namespace Sentir_Creativo_Backend.Audiencias.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddAudienciasPresenters(this IServiceCollection services)
    {
        services.AddScoped<SelectOrigenPresenter>();
        services.AddScoped<ISelectOrigenPresenter>(provider => provider.GetService<SelectOrigenPresenter>());
        services.AddScoped<ISelectOrigenOutputPort>(provider => provider.GetService<SelectOrigenPresenter>());
        
        return services;
    }
}