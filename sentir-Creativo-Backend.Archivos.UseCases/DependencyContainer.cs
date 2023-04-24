using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Create;
using sentir_Creativo_Backend.Archivos.UseCases.Archivos.Create;

namespace sentir_Creativo_Backend.Archivos.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddArchivosUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ICreateArchivoInputPort, CreateArchivoInteractor>();
        
        return services;
    }
}