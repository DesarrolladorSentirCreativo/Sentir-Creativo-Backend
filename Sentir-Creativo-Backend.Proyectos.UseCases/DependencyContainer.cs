using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports.EstadoProyectos.Select;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports.TipoProyectos;
using Sentir_Creativo_Backend.Proyectos.UseCases.EstadoProyectos.Select;
using Sentir_Creativo_Backend.Proyectos.UseCases.TipoProyectos.Select;

namespace Sentir_Creativo_Backend.Proyectos.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddProyectosUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ISelectTipoProyectoInputPort, SelectTipoProyectoInteractor>();
        services.AddScoped<ISelectEstadoProyectoInputPort, SelectEstadoProyectoInteractor>();
        
        return services;
    }
}