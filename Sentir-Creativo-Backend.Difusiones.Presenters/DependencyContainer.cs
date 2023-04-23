using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.Ports;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.Presenters;
using Sentir_Creativo_Backend.Difusiones.Presenters.Difusiones;

namespace Sentir_Creativo_Backend.Difusiones.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddDifusionesPresenters(this IServiceCollection services)
    {
        services.AddScoped<SelectDifusionPresenter>();
        services.AddScoped<ISelectDifusionPresenter>(provider => provider.GetService<SelectDifusionPresenter>());
        services.AddScoped<ISelectDifusionOutputPort>(provider => provider.GetService<SelectDifusionPresenter>());
        
        return services;
    }
}