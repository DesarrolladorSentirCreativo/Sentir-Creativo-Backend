namespace Sentir_Creativo_Backend.PublicoObjetivos.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddPublicoObjetivosPresenters(this IServiceCollection services)
    {
        services.AddScoped<SelectPublicoObjetivoPresenter>();
        services.AddScoped<ISelectPublicoObjetivoPresenter>(provider => provider.GetService<SelectPublicoObjetivoPresenter>());
        services.AddScoped<ISelectPublicoObjetivoOutputPort>(provider => provider.GetService<SelectPublicoObjetivoPresenter>());

        services.AddScoped<CreatePublicoObjetivoPresenter>();
        services.AddScoped<ICreatePublicoObjetivoPresenter>(provider => provider.GetService<CreatePublicoObjetivoPresenter>());
        services.AddScoped<ICreatePublicoObjetivoOutputPort>(provider => provider.GetService<CreatePublicoObjetivoPresenter>());

        services.AddScoped<UpdatePublicoObjetivoPresenter>();
        services.AddScoped<IUpdatePublicoObjetivoPresenter>(provider => provider.GetService<UpdatePublicoObjetivoPresenter>());
        services.AddScoped<IUpdatePublicoObjetivoOutputPort>(provider => provider.GetService<UpdatePublicoObjetivoPresenter>());

        services.AddScoped<DeletePublicoObjetivoPresenter>();
        services.AddScoped<IDeletePublicoObjetivoPresenter>(provider => provider.GetService<DeletePublicoObjetivoPresenter>());
        services.AddScoped<IDeletePublicoObjetivoOutputPort>(provider => provider.GetService<DeletePublicoObjetivoPresenter>());

        services.AddScoped<GetAllPublicoObjetivoPresenter>();
        services.AddScoped<IGetAllPublicoObjetivoPresenter>(provider => provider.GetService<GetAllPublicoObjetivoPresenter>());
        services.AddScoped<IGetAllPublicoObjetivoOutputPort>(provider => provider.GetService<GetAllPublicoObjetivoPresenter>());

        services.AddScoped<GetByIdPublicoObjetivoPresenter>();
        services.AddScoped<IGetByIdPublicoObjetivoPresenter>(provider => provider.GetService<GetByIdPublicoObjetivoPresenter>());
        services.AddScoped<IGetByIdPublicoObjetivoOutputPort>(provider => provider.GetService<GetByIdPublicoObjetivoPresenter>());

        return services;
    }
}