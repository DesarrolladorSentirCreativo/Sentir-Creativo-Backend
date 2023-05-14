using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.Archivos;
using Sentir_Creativo_Backend.Archivos.Controllers.Archivos;

namespace Sentir_Creativo_Backend.Archivos.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddArchivosControllers(this IServiceCollection services)
    {
        services.AddScoped<ICreateArchivoController, CreateArchivoController>();
        services.AddScoped<IUpdateArchivoController, UpdateArchivoController>();
        services.AddScoped<IDeleteArchivoController, DeleteArchivoController>();
        
        return services;
    }
}