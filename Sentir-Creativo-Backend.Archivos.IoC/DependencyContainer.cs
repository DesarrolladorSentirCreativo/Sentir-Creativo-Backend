using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Archivos.Controllers;
using Sentir_creativo_Backend.Archivos.Presenters;
using sentir_Creativo_Backend.Archivos.UseCases;

namespace Sentir_Creativo_Backend.Archivos.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddArchivosServices(this IServiceCollection services)
    {
        services.AddArchivosUseCasesServices();
        services.AddArchivosControllers();
        services.AddArchivosPresenters();
        
        return services;
    }
}