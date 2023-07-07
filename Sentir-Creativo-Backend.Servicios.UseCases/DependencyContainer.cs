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
        services.AddScoped<ISelectTecnicaArtisticaInputPort, SelectTecnicaArtisticaInteractor>();


        //Ocacions

        services.AddScoped<ICreateOcacionInputPort, CreateOcacionInteractor>();
        services.AddScoped<IUpdateOcacionInputPort, UpdateOcacionInterator>();
        services.AddScoped<IDeleteOcacionInputPort, DeleteOcacionInteractor>();

        return services;
    }
}