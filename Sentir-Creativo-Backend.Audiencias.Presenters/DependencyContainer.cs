using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Antiguedades.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Cercanias.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Origenes.SelectOrigen;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Antiguedades;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Cercanias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Origenes;
using Sentir_Creativo_Backend.Audiencias.Presenters.Antiguedades;
using Sentir_Creativo_Backend.Audiencias.Presenters.Cercanias;
using Sentir_Creativo_Backend.Audiencias.Presenters.Origenes;

namespace Sentir_Creativo_Backend.Audiencias.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddAudienciasPresenters(this IServiceCollection services)
    {
        services.AddScoped<SelectOrigenPresenter>();
        services.AddScoped<ISelectOrigenPresenter>(provider => provider.GetService<SelectOrigenPresenter>());
        services.AddScoped<ISelectOrigenOutputPort>(provider => provider.GetService<SelectOrigenPresenter>());

        services.AddScoped<SelectAntiguedadPresenter>();
        services.AddScoped<ISelectAntiguedadPresenter>(provider => provider.GetService<SelectAntiguedadPresenter>());
        services.AddScoped<ISelectAntiguedadOutputPort>(provider => provider.GetService<SelectAntiguedadPresenter>());

        services.AddScoped<SelectCercaniaPresenter>();
        services.AddScoped<ISelectCercaniaPresenter>(provider => provider.GetService<SelectCercaniaPresenter>());
        services.AddScoped<ISelectCercaniaOutputPort>(provider => provider.GetService<SelectCercaniaPresenter>());
        
        return services;
    }
}