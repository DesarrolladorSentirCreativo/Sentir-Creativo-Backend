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

        //Ocaciones
        services.AddScoped<ICreateOcacionController, CreateOcacionController>();
        services.AddScoped<IUpdateOcacionController,  UpdateOcacionController>();
        services.AddScoped<IDeleteOcacionController, DeleteOcacionController>();
        services.AddScoped<IGetAllOcacionController, GetAllOcacionController>();
        services.AddScoped<ISelectOcacionController, SelectOcacionController>();


        return services;
    }
}