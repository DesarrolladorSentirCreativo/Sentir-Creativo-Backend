using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.Archivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.TipoArchivos;
using Sentir_Creativo_Backend.Archivos.Controllers.Archivos;
using Sentir_Creativo_Backend.Archivos.Controllers.TipoArchivos;

namespace Sentir_Creativo_Backend.Archivos.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddArchivosControllers(this IServiceCollection services)
    {
        services.AddScoped<ICreateArchivoController, CreateArchivoController>();
        services.AddScoped<IUpdateArchivoController, UpdateArchivoController>();
        services.AddScoped<IDeleteArchivoController, DeleteArchivoController>();
        services.AddScoped<IGetByIdArchivoController, GetByIdArchivoController>();
        
        //tipos de archivos
        services.AddScoped<ISelectTipoArchivoController, SelectTipoArchivoController>();
        
        return services;
    }
}