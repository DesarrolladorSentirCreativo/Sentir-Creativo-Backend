using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Ports.CuponesDescuentos.Select;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Presenters;
using Sentir_Creativo_Backend.CuponesDescuentos.Presenters.CuponesDescuentos;

namespace Sentir_Creativo_Backend.CuponesDescuentos.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddCuponesDescuentosPresenters(this IServiceCollection services)
    {
        services.AddScoped<SelectCuponDescuentoPresenter>();
        services.AddScoped<ISelectCuponDescuentoPresenter>(provider => provider.GetService<SelectCuponDescuentoPresenter>());
        services.AddScoped<ISelectCuponDescuentoOutputPort>(provider => provider.GetService<SelectCuponDescuentoPresenter>());
        
        return services;
    }
}