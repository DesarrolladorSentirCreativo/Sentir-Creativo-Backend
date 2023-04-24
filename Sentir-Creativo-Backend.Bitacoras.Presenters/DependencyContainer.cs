using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Ports.Bitacoras.Create;
using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Presenters.Bitacoras;
using Sentir_Creativo_Backend.Bitacoras.Presenters.Bitacoras;

namespace Sentir_Creativo_Backend.Bitacoras.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddBitacorasPresenters(this IServiceCollection services)
    {
        services.AddScoped<CreateBitacoraPresenter>();
        services.AddScoped<ICreateBitacoraPresenter>(provider => provider.GetService<CreateBitacoraPresenter>());
        services.AddScoped<ICreateBitacoraOutputPort>(provider => provider.GetService<CreateBitacoraPresenter>());
        
        return services;
    }
}