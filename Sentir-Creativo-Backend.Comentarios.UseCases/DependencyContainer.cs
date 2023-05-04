using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Create;
using Sentir_Creativo_Backend.Comentarios.UseCases.Create;

namespace Sentir_Creativo_Backend.Comentarios.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddComentariosUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ICreateComentarioInputPort, CreateComentarioInteractor>();
        
        return services;
    }
}