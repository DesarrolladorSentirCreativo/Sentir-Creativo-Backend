using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Ports.Areas.Select;
using Sentir_Creativo_Backend.Areas.UseCases.Areas.Select;

namespace Sentir_Creativo_Backend.Areas.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddAreasUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ISelectAreaInputPort, SelectAreaInteractor>();

        return services;
    }
}