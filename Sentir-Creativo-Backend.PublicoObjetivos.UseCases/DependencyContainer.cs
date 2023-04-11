using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.Select;
using Sentir_Creativo_Backend.PublicoObjetivos.UseCases.PublicoObjetivos.Select;

namespace Sentir_Creativo_Backend.PublicoObjetivos.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddPublicoObjetivosUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ISelectPublicoObjetivoInputPort, SelectPublicoObjetivoInteractor>();

        return services;
    }
}