using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Ciudades.Select;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Paises.Select;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Regiones.Select;
using Sentir_Creativo_Backend.Direcciones.UseCases.Ciudades.Select;
using Sentir_Creativo_Backend.Direcciones.UseCases.Paises.Select;
using Sentir_Creativo_Backend.Direcciones.UseCases.Regiones.Select;

namespace Sentir_Creativo_Backend.Direcciones.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddDireccionesUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ISelectPaisInputPort, SelectPaisInteractor>();
        services.AddScoped<ISelectRegionInputPort, SelectRegionInteractor>();
        services.AddScoped<ISelectCiudadInputPort, SelectCiudadInteractor>();
        
        return services;
    }
}