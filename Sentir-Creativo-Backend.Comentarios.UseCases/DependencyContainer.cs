using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Create;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Delete;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.GetById;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Update;
using Sentir_Creativo_Backend.Comentarios.UseCases.Create;
using Sentir_Creativo_Backend.Comentarios.UseCases.Delete;
using Sentir_Creativo_Backend.Comentarios.UseCases.GetById;
using Sentir_Creativo_Backend.Comentarios.UseCases.Update;

namespace Sentir_Creativo_Backend.Comentarios.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddComentariosUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ICreateComentarioInputPort, CreateComentarioInteractor>();
        services.AddScoped<IGetByIdComentarioInputPort, GetByIdComentarioInteractor>();
        services.AddScoped<IUpdateComentarioInputPort, UpdateComentarioInteractor>();
        services.AddScoped<IDeleteComentarioInputPort, DeleteComentarioInteractor>();
        
        return services;
    }
}