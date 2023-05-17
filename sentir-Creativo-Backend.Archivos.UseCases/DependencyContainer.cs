using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Create;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Delete;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.GetById;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Update;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.TipoArchivo.Select;
using sentir_Creativo_Backend.Archivos.UseCases.Archivos.Create;
using sentir_Creativo_Backend.Archivos.UseCases.Archivos.Delete;
using sentir_Creativo_Backend.Archivos.UseCases.Archivos.GetById;
using sentir_Creativo_Backend.Archivos.UseCases.Archivos.Update;
using sentir_Creativo_Backend.Archivos.UseCases.TipoArchivos;

namespace sentir_Creativo_Backend.Archivos.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddArchivosUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ICreateArchivoInputPort, CreateArchivoInteractor>();
        services.AddScoped<IUpdateArchivoInputPort, UpdateArchivoInteractor>();
        services.AddScoped<IDeleteArchivoInputPort, DeleteArchivoInteractor>();
        services.AddScoped<IGetByIdArchivoInputPort, GetByIdArchivoInteractor>();
        services.AddScoped<ISelectTipoArchivoInputPort, SelectTipoArchivoInteractor>();
        
        return services;
    }
}