using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports.EstadoProyectos.Select;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports.TipoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Presenters.EstadoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Presenters.TipoProyectos;
using Sentir_Creativo_Backend.Proyectos.Presenters.EstadoProyectos;
using Sentir_Creativo_Backend.Proyectos.Presenters.TiposProyectos;

namespace Sentir_Creativo_Backend.Proyectos.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddProyectosPresenters(this IServiceCollection services)
    {
        services.AddScoped<SelectTipoProyectoPresenter>();
        services.AddScoped<ISelectTipoProyectoPresenter>(provider => provider.GetService<SelectTipoProyectoPresenter>());
        services.AddScoped<ISelectTipoProyectoOutPort>(provider => provider.GetService<SelectTipoProyectoPresenter>());

        services.AddScoped<SelectEstadoProyectoPresenter>();
        services.AddScoped<ISelectEstadoProyectoPresenter>(provider => provider.GetService<SelectEstadoProyectoPresenter>());
        services.AddScoped<ISelectEstadoProyectoOuputPort>(provider => provider.GetService<SelectEstadoProyectoPresenter>());
        
        return services;
    }
}