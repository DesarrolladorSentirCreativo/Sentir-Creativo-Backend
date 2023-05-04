using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Controllers;
using Sentir_Creativo_Backend.Comentarios.Controllers.Comentarios;

namespace Sentir_Creativo_Backend.Comentarios.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddComentariosControllers(this IServiceCollection services)
    {
        services.AddScoped<ICreateComentarioController, CreateComentarioController>();
        services.AddScoped<IGetByIdComentarioController, GetByIdComentarioController>();
        
        return services;
    }
}