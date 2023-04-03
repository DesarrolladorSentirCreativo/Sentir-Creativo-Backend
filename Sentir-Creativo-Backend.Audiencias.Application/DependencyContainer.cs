using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Sentir_Creativo_Backend.Audiencias.Application;

public static class DependencyContainer 
{
    public static IServiceCollection AddAudienciasApplicationServices(this IServiceCollection services,
        IConfiguration configuration)
    {

        return services;
    }
}