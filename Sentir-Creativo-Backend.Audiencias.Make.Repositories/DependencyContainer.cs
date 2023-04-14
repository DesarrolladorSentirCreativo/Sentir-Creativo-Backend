using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Services;
using Sentir_Creativo_Backend.Audiencias.Make.Repositories.Services.Audiencia;

namespace Sentir_Creativo_Backend.Audiencias.Make.Repositories;

public static class DependencyContainer
{
    public static IServiceCollection AddAudienciasMakeServices(this IServiceCollection services)
    {
        services.AddScoped<ICreateAudienciaService, CreateAudienciaService>();
        services.AddScoped<IUpdateAudienciaService, UpdateAudienciaService>();
        
        return services;
    }
}