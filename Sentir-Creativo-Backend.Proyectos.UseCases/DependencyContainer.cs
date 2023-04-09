using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports;
using Sentir_Creativo_Backend.Proyectos.UseCases.TipoProyectos.Select;

namespace Sentir_Creativo_Backend.Proyectos.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddProyectosUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ISelectTipoProyectoInputPort, SelectTipoProyectoInteractor>();
        
        return services;
    }
}