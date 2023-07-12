namespace Sentir_Creativo_Backend.PublicoObjetivos.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddPublicoObjetivosControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectPublicoObjetivoController, SelectPublicoObjetivoController>();
        services.AddScoped<ICreatePublicoObjetivoController, CreatePublicoObjetivoController>();
        services.AddScoped<IUpdatePublicoObjetivoController, UpdatePublicoObjetivoController>();
        services.AddScoped<IDeletePublicoObjetivoController, DeletePublicoObjetivoController>();
        services.AddScoped<IGetAllPublicoObjetivoController, GetAllPublicoObjetivoController>();
        services.AddScoped<IGetByIdPublicoObjetivoController, GetByIdPublicoObjetivoController>();

        return services;
    }
}