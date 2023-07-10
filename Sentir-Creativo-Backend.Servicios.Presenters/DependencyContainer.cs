namespace Sentir_Creativo_Backend.Servicios.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddServiciosPresenters(this IServiceCollection services)
    {

        //estados servicios

        services.AddScoped<SelectEstadoServicioPresenter>();
        services.AddScoped<ISelectEstadoServicioPresenter>(provider => provider.GetService<SelectEstadoServicioPresenter>());
        services.AddScoped<ISelectEstadoServicioOutputPort>(provider => provider.GetService<SelectEstadoServicioPresenter>());

        services.AddScoped<UpdateEstadoServicioPresenter>();
        services.AddScoped<IUpdateEstadoServicioPresenter>(provider => provider.GetService<UpdateEstadoServicioPresenter>());
        services.AddScoped<IUpdateEstadoServicioOutputPort>(provider => provider.GetService<UpdateEstadoServicioPresenter>());

        services.AddScoped<DeleteEstadoServicioPresenter>();
        services.AddScoped<IDeleteEstadoServicioPresenter>(provider => provider.GetService<DeleteEstadoServicioPresenter>());
        services.AddScoped<IDeleteEstadoServicioOutputPort>(provider => provider.GetService<DeleteEstadoServicioPresenter>());

        services.AddScoped<CreateEstadoServicioPresenter>();
        services.AddScoped<ICreateEstadoServicioPresenter>(provider => provider.GetService<CreateEstadoServicioPresenter>());
        services.AddScoped<ICreateEstadoServicioOutputPort>(provider => provider.GetService<CreateEstadoServicioPresenter>());

        services.AddScoped<GetAllEstadoServicioPresenter>();
        services.AddScoped<IGetAllEstadoServicioPresenter>(provider => provider.GetService<GetAllEstadoServicioPresenter>());
        services.AddScoped<IGetAllEstadoServicioOutputPort>(provider => provider.GetService<GetAllEstadoServicioPresenter>());

        services.AddScoped<GetByIdEstadoServicioPresenter>();
        services.AddScoped<IGetByIdEstadoServicioPresenter>(provider => provider.GetService<GetByIdEstadoServicioPresenter>());
        services.AddScoped<IGetByIdEstadoServicioOutputPort>(provider => provider.GetService<GetByIdEstadoServicioPresenter>());

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


        //Ocaciones
        services.AddScoped<CreateOcacionPresenter>();
        services.AddScoped<ICreateOcacionPresenter>(provider => provider.GetService<CreateOcacionPresenter>());
        services.AddScoped<ICreateOcacionOutputPort>(provider => provider.GetService<CreateOcacionPresenter>());

        services.AddScoped<UpdateOcacionPresenter>();
        services.AddScoped<IUpdateOcacionPresenter>(provider => provider.GetService<UpdateOcacionPresenter>());
        services.AddScoped<IUpdateOcacionOutputPort>(provider => provider.GetService<UpdateOcacionPresenter>());

        services.AddScoped<DeleteOcacionPresenter>();
        services.AddScoped<IDeleteOcacionPresenter>(provider => provider.GetService<DeleteOcacionPresenter>());
        services.AddScoped<IDeleteOcacionOutputPort>(provider => provider.GetService<DeleteOcacionPresenter>());

        services.AddScoped<GetAllOcacionPresenter>();
        services.AddScoped<IGetAllOcacionPresenter>(provider => provider.GetService<GetAllOcacionPresenter>());
        services.AddScoped<IGetAllOcacionOutputPort>(provider => provider.GetService<GetAllOcacionPresenter>());

        services.AddScoped<SelectOcacionPresenter>();
        services.AddScoped<ISelectOcacionPresenter>(provider => provider.GetService<SelectOcacionPresenter>());
        services.AddScoped<ISelectOcacionOutputPort>(provider => provider.GetService<SelectOcacionPresenter>());


        services.AddScoped<GetByIdOcacionPresenter>();
        services.AddScoped<IGetByIdOcacionPresenter>(provider => provider.GetService<GetByIdOcacionPresenter>());
        services.AddScoped<IGetByIdOcacionOutputPort>(provider => provider.GetService<GetByIdOcacionPresenter>());

        return services;
    }
}