namespace Sentir_Creativo_Backend.PublicoObjetivos.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddPublicoObjetivosUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ISelectPublicoObjetivoInputPort, SelectPublicoObjetivoInteractor>();
        services.AddScoped<ICreatePublicoObjetivoInputPort, CreatePublicoObjetivoInteractor>();
        services.AddScoped<IUpdatePublicoObjetivoInputPort, UpdatePublicoObjetivoInteractor>();
        services.AddScoped<IDeletePublicoObjetivoInputPort, DeletePublicoObjetivoInteractor>();
        services.AddScoped<IGetAllPublicoObjetivoInputPort, GetAllPublicoObjetivoInteractor>();
        services.AddScoped<IGetByIdPublicoObjetivoInputPort, GetByIdPublicoObjetivoInteractor>();

        return services;
    }
}