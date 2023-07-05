using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Create;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Delete;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetAll;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetById;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Update;
using Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.Select;
using Sentir_Creativo_Backend.Servicios.UseCases.Formatos.Select;
using Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.Create;
using Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.Delete;
using Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.GetAll;
using Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.GetById;
using Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.Update;

namespace Sentir_Creativo_Backend.Servicios.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddServiciosUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ISelectEstadoServicioInputPort, SelectEstadoServicioInteractor>();
        services.AddScoped<ISelectFormatoInputPort, SelectFormatoInteractor>();

        //tecnica artisticas
        services.AddScoped<ICreateTecnicaArtisticaInputPort, CreateTecnicaArtisticaInteractor>();
        services.AddScoped<IUpdateTecnicaArtisticaInputPort, UpdateTecnicaArtisticaInteractor>();
        services.AddScoped<IDeleteTecnicaArtisticaInputPort, DeleteTecnicaArtisticaInteractor>();
        services.AddScoped<IGetByIdTecnicaArtisticaInputPort, GetByIdTecnicaArtisticaInteractor>();
        services.AddScoped<IGetAllTecnicaArtisticaInputPort, GetAllTecnicaArtisticaInteractor>();


        return services;
    }
}