using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Create;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Delete;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Update;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Formatos;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.Presenters.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.Presenters.Formatos;
using Sentir_Creativo_Backend.Servicios.Presenters.TecnicaArtisticas;

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

        //tecnicas artisticas
        services.AddScoped<CreateTecnicaArtisticaPresenter>();
        services.AddScoped<ICreateTecnicaArtisticaPresenter>(provider => provider.GetService<CreateTecnicaArtisticaPresenter>());
        services.AddScoped<ICreateTecnicaArtisticaOutputPort>(provider => provider.GetService<CreateTecnicaArtisticaPresenter>());

        services.AddScoped<UpdateTecnicaArtisticaPresenter>();
        services.AddScoped<IUpdateTecnicaArtisticaPresenter>(provider => provider.GetService<UpdateTecnicaArtisticaPresenter>());
        services.AddScoped<IUpdateTecnicaArtisticaOutputPort>(provider => provider.GetService<UpdateTecnicaArtisticaPresenter>());

        services.AddScoped<DeleteTecnicaArtisticaPresenter>();
        services.AddScoped<IDeleteTecnicaArtisticaPresenter>(provider => provider.GetService<DeleteTecnicaArtisticaPresenter>());
        services.AddScoped<IDeleteTecnicaArtisticaOutputPort>(provider => provider.GetService<DeleteTecnicaArtisticaPresenter>());

        return services;
    }
}