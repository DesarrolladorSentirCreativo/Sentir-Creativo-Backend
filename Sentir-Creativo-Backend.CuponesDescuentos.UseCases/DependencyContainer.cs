using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Ports.CuponesDescuentos.Select;
using Sentir_Creativo_Backend.CuponesDescuentos.UseCases.CuponesDescuentos.Select;

namespace Sentir_Creativo_Backend.CuponesDescuentos.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddCuponesDescuentosUseCasesService(this IServiceCollection services)
    {
        services.AddScoped<ISelectCuponDescuentoInputPort, SelectCuponDescuentoInteractor>();
        return services;
    }
}