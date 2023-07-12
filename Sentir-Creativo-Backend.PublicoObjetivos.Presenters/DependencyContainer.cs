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

        return services;
    }
}