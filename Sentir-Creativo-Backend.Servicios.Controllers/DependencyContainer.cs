using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Formatos;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.Controllers.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.Controllers.Formatos;
using Sentir_Creativo_Backend.Servicios.Controllers.TecnicaArtisticas;

namespace Sentir_Creativo_Backend.Servicios.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddServiciosControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectEstadoServicioController, SelectEstadoServicioController>();
        services.AddScoped<ISelectFormatoController, SelectFormatoController>();

        //tecnicas artisticas
        services.AddScoped<ICreateTecnicaArtisticaController, CreateTecnicaArtisticaController>();
        services.AddScoped<IUpdateTecnicaArtisticaController, UpdateTecnicaArtisticaController>();
        services.AddScoped<IDeleteTecnicaArtisitcaController, DeleteTecnicaArtisticaController>();
        services.AddScoped<IGetByIdTecnicaArtisticaController, GetByIdTecnicaArtisticaController>();
        services.AddScoped<IGetAllTecnicaArtisticaController, GetAllTecnicaArtisticaController>();
        services.AddScoped<ISelectTecnicaArtisticaController, SelectTecnicaArtisticaController>();
        
        return services;
    }
}