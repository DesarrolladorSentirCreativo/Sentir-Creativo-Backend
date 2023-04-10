using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Controllers.EstadoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Controllers.TipoProyectos;
using Sentir_Creativo_Backend.Proyectos.Controllers.EstadoProyectos;
using Sentir_Creativo_Backend.Proyectos.Controllers.TipoProyectos;

namespace Sentir_Creativo_Backend.Proyectos.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddProyectosControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectTipoProyectoController, SelectTipoProyectoController>();
        services.AddScoped<ISelectEstadoProyectoController, SelectEstadoProyectoController>();
        
        return services;
    }
}