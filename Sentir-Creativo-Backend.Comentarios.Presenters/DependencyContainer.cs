using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Create;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Delete;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.GetById;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Update;
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
        
        services.AddScoped<GetByIdComentarioPresenter>();
        services.AddScoped<IGetByIdComentarioPresenter>(provider => provider.GetService<GetByIdComentarioPresenter>());
        services.AddScoped<IGetByIdComentarioOutputPort>(provider => provider.GetService<GetByIdComentarioPresenter>());
        
        services.AddScoped<UpdateComentarioPresenter>();
        services.AddScoped<IUpdateComentarioPresenter>(provider => provider.GetService<UpdateComentarioPresenter>());
        services.AddScoped<IUpdateComentarioOutputPort>(provider => provider.GetService<UpdateComentarioPresenter>());
        
        services.AddScoped<DeleteComentarioPresenter>();
        services.AddScoped<IDeleteComentarioPresenter>(provider => provider.GetService<DeleteComentarioPresenter>());
        services.AddScoped<IDeleteComentarioOutputPort>(provider => provider.GetService<DeleteComentarioPresenter>());
        
        return services;
    }
}