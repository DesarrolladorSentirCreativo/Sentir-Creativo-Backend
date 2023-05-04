using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Create;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.GetById;
using Sentir_Creativo_Backend.Comentarios.UseCases.Create;
using Sentir_Creativo_Backend.Comentarios.UseCases.GetById;

namespace Sentir_Creativo_Backend.Comentarios.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddComentariosUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ICreateComentarioInputPort, CreateComentarioInteractor>();
        services.AddScoped<IGetByIdComentarioInputPort, GetByIdComentarioInteractor>();
        
        return services;
    }
}