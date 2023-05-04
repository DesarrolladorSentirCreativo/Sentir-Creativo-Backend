using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Create;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Presenters;
using Sentir_Creativo_Backend.Comentarios.Presenters.Comentarios;

namespace Sentir_Creativo_Backend.Comentarios.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddComentariosPresenters(this IServiceCollection services)
    {
        services.AddScoped<CreateComentarioPresenter>();
        services.AddScoped<ICreateComentarioPresenter>(provider => provider.GetService<CreateComentarioPresenter>());
        services.AddScoped<ICreateComentarioOutputPort>(provider => provider.GetService<CreateComentarioPresenter>());
        
        return services;
    }
}