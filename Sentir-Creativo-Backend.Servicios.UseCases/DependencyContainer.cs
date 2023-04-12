using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.EstadosServicios.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Select;
using Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.Select;
using Sentir_Creativo_Backend.Servicios.UseCases.Formatos.Select;

namespace Sentir_Creativo_Backend.Servicios.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddServiciosUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ISelectEstadoServicioInputPort, SelectEstadoServicioInteractor>();
        services.AddScoped<ISelectFormatoInputPort, SelectFormatoInteractor>();

        return services;
    }
}