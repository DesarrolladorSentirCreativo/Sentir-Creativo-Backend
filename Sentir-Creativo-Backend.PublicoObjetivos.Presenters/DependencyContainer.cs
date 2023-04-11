using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.Select;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Presenters.PublicoObjetivos;
using Sentir_Creativo_Backend.PublicoObjetivos.Presenters.PublicoObjetivos;

namespace Sentir_Creativo_Backend.PublicoObjetivos.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddPublicoObjetivosPresenters(this IServiceCollection services)
    {
        services.AddScoped<SelectPublicoObjetivoPresenter>();
        services.AddScoped<ISelectPublicoObjetivoPresenter>(provider => provider.GetService<SelectPublicoObjetivoPresenter>());
        services.AddScoped<ISelectPublicoObjetivoOutputPort>(provider => provider.GetService<SelectPublicoObjetivoPresenter>());   
        
        return services;
    }
}