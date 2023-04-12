using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Ports.Areas.Select;
using Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Presenters.Areas;
using Sentir_Creativo_Backend.Areas.Presenters.Areas;

namespace Sentir_Creativo_Backend.Areas.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddAreasPresenters(this IServiceCollection services)
    {
        services.AddScoped<SelectAreaPresenter>();
        services.AddScoped<ISelectAreaPresenter>(provider => provider.GetService<SelectAreaPresenter>());
        services.AddScoped<ISelectAreaOutputPort>(provider => provider.GetService<SelectAreaPresenter>());   
        
        return services;
    }
}