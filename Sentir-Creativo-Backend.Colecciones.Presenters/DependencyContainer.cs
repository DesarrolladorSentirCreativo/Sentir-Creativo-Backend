using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Ports.Colecciones.Select;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Presenters.Colecciones;
using Sentir_Creativo_Backend.Colecciones.Presenters.Colecciones;

namespace Sentir_Creativo_Backend.Colecciones.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddColeccionesPresenters(this IServiceCollection services)
    {
        services.AddScoped<SelectColeccionPresenter>();
        services.AddScoped<ISelectColeccionPresenter>(provider => provider.GetService<SelectColeccionPresenter>());
        services.AddScoped<ISelectColeccionOutputPort>(provider => provider.GetService<SelectColeccionPresenter>());   
        
        return services;
    }
}