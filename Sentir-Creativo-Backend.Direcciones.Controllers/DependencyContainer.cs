using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Ciudades;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Paises;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Regiones;
using Sentir_Creativo_Backend.Direcciones.Controllers.Ciudades;
using Sentir_Creativo_Backend.Direcciones.Controllers.Paises;
using Sentir_Creativo_Backend.Direcciones.Controllers.Regiones;

namespace Sentir_Creativo_Backend.Direcciones.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddDireccionesControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectPaisController, SelectPaisController>();
        services.AddScoped<ISelectRegionController, SelectRegionController>();
        services.AddScoped<ISelectCiudadController, SelectCiudadController>();
        
        return services;
    }
}