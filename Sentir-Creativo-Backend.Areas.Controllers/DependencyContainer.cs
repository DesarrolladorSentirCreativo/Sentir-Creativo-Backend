using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Controllers.Areas;
using Sentir_Creativo_Backend.Areas.Controllers.Areas;

namespace Sentir_Creativo_Backend.Areas.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddAreasControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectAreaController, SelectAreaController>();

        return services;
    }
}