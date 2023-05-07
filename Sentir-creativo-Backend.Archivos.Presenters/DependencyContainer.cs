using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Create;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Update;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.Archivos;
using Sentir_creativo_Backend.Archivos.Presenters.Archivos;

namespace Sentir_creativo_Backend.Archivos.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddArchivosPresenters(this IServiceCollection services)
    {
        services.AddScoped<CreateArchivoPresenter>();
        services.AddScoped<ICreateArchivoPresenter>(provider => provider.GetService<CreateArchivoPresenter>());
        services.AddScoped<ICreateArchivoOutputPort>(provider => provider.GetService<CreateArchivoPresenter>());
        
        services.AddScoped<UpdateArchivoPresenter>();
        services.AddScoped<IUpdateArchivoPresenter>(provider => provider.GetService<UpdateArchivoPresenter>());
        services.AddScoped<IUpdateArchivoOutputPort>(provider => provider.GetService<UpdateArchivoPresenter>());
        
        return services;
    }
}