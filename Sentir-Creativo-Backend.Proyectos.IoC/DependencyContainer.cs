using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Proyectos.Controllers;
using Sentir_Creativo_Backend.Proyectos.Presenters;
using Sentir_Creativo_Backend.Proyectos.UseCases;

namespace Sentir_Creativo_Backend.Proyectos.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddProyectosServices(this IServiceCollection services)
    {
        services.AddProyectosUseCasesServices();
        services.AddProyectosPresenters();
        services.AddProyectosControllers();
        
        return services;
    }
}