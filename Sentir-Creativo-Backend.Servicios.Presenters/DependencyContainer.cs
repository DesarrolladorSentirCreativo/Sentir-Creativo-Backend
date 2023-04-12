using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Formatos;
using Sentir_Creativo_Backend.Servicios.Presenters.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.Presenters.Formatos;

namespace Sentir_Creativo_Backend.Servicios.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddServiciosPresenters(this IServiceCollection services)
    {
        services.AddScoped<SelectEstadoServicioPresenter>();
        services.AddScoped<ISelectEstadoServicioPresenter>(provider => provider.GetService<SelectEstadoServicioPresenter>());
        services.AddScoped<ISelectEstadoServicioOutputPort>(provider => provider.GetService<SelectEstadoServicioPresenter>());   
        
        services.AddScoped<SelectFormatoPresenter>();
        services.AddScoped<ISelectFormatoPresenter>(provider => provider.GetService<SelectFormatoPresenter>());
        services.AddScoped<ISelectFormatoOutputPort>(provider => provider.GetService<SelectFormatoPresenter>()); 
        
        return services;
    }
}