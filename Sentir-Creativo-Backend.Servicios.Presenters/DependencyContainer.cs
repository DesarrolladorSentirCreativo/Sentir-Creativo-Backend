using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Create;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Delete;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetAll;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetById;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Update;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Formatos;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.Presenters.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.Presenters.Formatos;
using Sentir_Creativo_Backend.Servicios.Presenters.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.Presenters.Ocacions;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Create;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Ocacions;

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

        services.AddScoped<GetByIdTecnicaArtisticaPresenter>();
        services.AddScoped<IGetByIdTecnicaArtisticaPresenter>(provider => provider.GetService<GetByIdTecnicaArtisticaPresenter>());
        services.AddScoped<IGetByIdTecnicaArtisticaOutputPort>(provider => provider.GetService<GetByIdTecnicaArtisticaPresenter>());

        services.AddScoped<GetAllTecnicaArtisticaPresenter>();
        services.AddScoped<IGetAllTecnicaArtisticaPresenter>(provider => provider.GetService<GetAllTecnicaArtisticaPresenter>());
        services.AddScoped<IGetAllTecnicaArtisticaOutputPort>(provider => provider.GetService<GetAllTecnicaArtisticaPresenter>());

        services.AddScoped<SelectTecnicaArtisticaPresenter>();
        services.AddScoped<ISelectTecnicaArtisticaPresenter>(provider => provider.GetService<SelectTecnicaArtisticaPresenter>());
        services.AddScoped<ISelectTecnicaArtisticaOutputPort>(provider => provider.GetService<SelectTecnicaArtisticaPresenter>());


        //Ocacions

        services.AddScoped<CreateOcacionPresenter>();
        services.AddScoped<ICreateOcacionPresenter>(provider => provider.GetService<CreateOcacionPresenter>());
        services.AddScoped<ICreateOcacionOutputPort>(provider => provider.GetService<CreateOcacionPresenter>());

        return services;
    }
}