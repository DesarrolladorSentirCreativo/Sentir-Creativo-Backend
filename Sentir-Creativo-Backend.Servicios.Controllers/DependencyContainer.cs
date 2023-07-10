namespace Sentir_Creativo_Backend.Servicios.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddServiciosControllers(this IServiceCollection services)
    {
        //estados servicios
        services.AddScoped<ISelectEstadoServicioController, SelectEstadoServicioController>();
        services.AddScoped<ICreateEstadoServicioController, CreateEstadoServicioController>();
        services.AddScoped<IUpdateEstadoServicioController, UpdateEstadoServicioController>();
        services.AddScoped<IDeleteEstadoServicioController, DeleteEstadoServicioController>();
        services.AddScoped<IGetAllEstadoServicioController, GetAllEstadoServicioController>();
        services.AddScoped<IGetByIdEstadoServicioController, GetByIdEstadoServicioController>();

        //foematos
        services.AddScoped<ISelectFormatoController, SelectFormatoController>();
        services.AddScoped<ICreateFormatoController, CreateFormatoController>();

        //tecnicas artisticas
        services.AddScoped<ICreateTecnicaArtisticaController, CreateTecnicaArtisticaController>();
        services.AddScoped<IUpdateTecnicaArtisticaController, UpdateTecnicaArtisticaController>();
        services.AddScoped<IDeleteTecnicaArtisitcaController, DeleteTecnicaArtisticaController>();
        services.AddScoped<IGetByIdTecnicaArtisticaController, GetByIdTecnicaArtisticaController>();
        services.AddScoped<IGetAllTecnicaArtisticaController, GetAllTecnicaArtisticaController>();
        services.AddScoped<ISelectTecnicaArtisticaController, SelectTecnicaArtisticaController>();

        //Ocaciones
        services.AddScoped<ICreateOcacionController, CreateOcacionController>();
        services.AddScoped<IUpdateOcacionController,  UpdateOcacionController>();
        services.AddScoped<IDeleteOcacionController, DeleteOcacionController>();
        services.AddScoped<IGetAllOcacionController, GetAllOcacionController>();
        services.AddScoped<ISelectOcacionController, SelectOcacionController>();
        services.AddScoped<IGetByIdOcacionController, GetByIdOcacionController>();


        return services;
    }
}