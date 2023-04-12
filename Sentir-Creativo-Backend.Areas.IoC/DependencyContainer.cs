using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Areas.Controllers;
using Sentir_Creativo_Backend.Areas.Presenters;
using Sentir_Creativo_Backend.Areas.UseCases;

namespace Sentir_Creativo_Backend.Areas.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddAreasServices(this IServiceCollection services)
    {
        services.AddAreasUseCasesServices();
        services.AddAreasPresenters();
        services.AddAreasControllers();
        
        return services;
    }
}