using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Create;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Delete;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.GetById;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Update;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.TipoArchivo.Select;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.Archivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.TipoArchivo;
using Sentir_creativo_Backend.Archivos.Presenters.Archivos;
using Sentir_creativo_Backend.Archivos.Presenters.TipoArchivos;

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
        
        services.AddScoped<DeleteArchivoPresenter>();
        services.AddScoped<IDeleteArchivoPresenter>(provider => provider.GetService<DeleteArchivoPresenter>());
        services.AddScoped<IDeleteArchivoOutputPort>(provider => provider.GetService<DeleteArchivoPresenter>());
        
        services.AddScoped<GetByIdArchivoPresenter>();
        services.AddScoped<IGetByIdArchivoPresenter>(provider => provider.GetService<GetByIdArchivoPresenter>());
        services.AddScoped<IGetByIdArchivoOutputPort>(provider => provider.GetService<GetByIdArchivoPresenter>());
        
        services.AddScoped<SelectTipoArchivoPresenter>();
        services.AddScoped<ISelectTipoArchivoPresenter>(provider => provider.GetService<SelectTipoArchivoPresenter>());
        services.AddScoped<ISelectTipoArchivoOutputPort>(provider => provider.GetService<SelectTipoArchivoPresenter>());
        
        return services;
    }
}