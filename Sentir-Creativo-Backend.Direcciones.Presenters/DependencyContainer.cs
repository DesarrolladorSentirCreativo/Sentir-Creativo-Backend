using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Paises.Select;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Presenters.Paises;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Paises;
using Sentir_Creativo_Backend.Direcciones.Presenters.Paises;

namespace Sentir_Creativo_Backend.Direcciones.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddDireccionesPresenters(this IServiceCollection services)
    {
        services.AddScoped<SelectPaisPresenter>();
        services.AddScoped<ISelectPaisPresenter>(provider => provider.GetService<SelectPaisPresenter>());
        services.AddScoped<ISelectPaisOutputPort>(provider => provider.GetService<SelectPaisPresenter>());
        
        return services;
    }
}