using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Comentarios.Controllers;
using Sentir_Creativo_Backend.Comentarios.Presenters;
using Sentir_Creativo_Backend.Comentarios.UseCases;

namespace Sentir_Creativo_Backend.Comentarios.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddComentariosServices(this IServiceCollection services)
    {
        services.AddComentariosUseCasesServices();
        services.AddComentariosControllers();
        services.AddComentariosPresenters();
        
        return services;
    }
}