namespace Sentir_Creativo_Backend.Servicios.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddServiciosUseCasesServices(this IServiceCollection services)
    {

        //estados servicios
        services.AddScoped<ISelectEstadoServicioInputPort, SelectEstadoServicioInteractor>();
        services.AddScoped<ICreateEstadoServicioInputPort, CreateEstadoServicioInteractor>();
        services.AddScoped<IUpdateEstadoServicioInputPort, UpdateEstadoServicioInteractor>();
        services.AddScoped<IDeleteEstadoServicioInputPort, DeleteEstadoServicioInteractor>();
        services.AddScoped<IGetAllEstadoServicioInputPort, GetAllEstadoServicioInteractor>();
        services.AddScoped<IGetByIdEstadoServicioInputPort, GetByIdEstadoServicioInteractor>();

        //formatos
        services.AddScoped<ISelectFormatoInputPort, SelectFormatoInteractor>();
        services.AddScoped<ICreateFormatoInputPort, CreateFormatoInteractor>();
        services.AddScoped<IUpdateFormatoInputPort, UpdateFormatoInteractor>();
        services.AddScoped<IDeleteFormatoInputPort, DeleteFormatoInteractor>();
        services.AddScoped<IGetAllFormatoInputPort, GetAllFormatoInteractor>();
        services.AddScoped<IGetByIdFormatoInputPort, GetByIdFormatoInteractor>();

        //tecnica artisticas
        services.AddScoped<ICreateTecnicaArtisticaInputPort, CreateTecnicaArtisticaInteractor>();
        services.AddScoped<IUpdateTecnicaArtisticaInputPort, UpdateTecnicaArtisticaInteractor>();
        services.AddScoped<IDeleteTecnicaArtisticaInputPort, DeleteTecnicaArtisticaInteractor>();
        services.AddScoped<IGetByIdTecnicaArtisticaInputPort, GetByIdTecnicaArtisticaInteractor>();
        services.AddScoped<IGetAllTecnicaArtisticaInputPort, GetAllTecnicaArtisticaInteractor>();
        services.AddScoped<ISelectTecnicaArtisticaInputPort, SelectTecnicaArtisticaInteractor>();


        //Ocaciones
        services.AddScoped<ICreateOcacionInputPort, CreateOcacionInteractor>();
        services.AddScoped<IUpdateOcacionInputPort, UpdateOcacionInterator>();
        services.AddScoped<IDeleteOcacionInputPort, DeleteOcacionInteractor>();
        services.AddScoped<IGetAllOcacionInputPort, GetAllOcacionInteractor>();
        services.AddScoped<ISelectOcacionInputPort, SelectOcacionInteractor>();
        services.AddScoped<IGetByIdOcacionInputPort, GetByIdOcacionInteractor>();



        return services;
    }
}