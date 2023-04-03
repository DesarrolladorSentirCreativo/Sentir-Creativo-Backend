using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories;
using Sentir_Creativo_Backend.Audiencias.Persistence.Repositories;

namespace Sentir_Creativo_Backend.Audiencias.Persistence;

public static class DependencyContainer
{
     public static IServiceCollection AddAudienciaPersistenceServices(this IServiceCollection services)
     {
          services.AddScoped<IAudienciaReadRepository, AudienciaReadRepository>();
          services.AddScoped<IAudienciaWriteRepository, AudienciaWriteRepository>();
          
          return services;
     }
}