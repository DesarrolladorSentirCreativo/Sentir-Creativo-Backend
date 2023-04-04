using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Audiencias;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Cercanias;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.EstadoAudiencias;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Origenes;
using Sentir_Creativo_Backend.Audiencias.Domain.Repositories.Prefijos;
using Sentir_Creativo_Backend.Audiencias.Persistence.Repositories.Audiencias;
using Sentir_Creativo_Backend.Audiencias.Persistence.Repositories.Cercanias;
using Sentir_Creativo_Backend.Audiencias.Persistence.Repositories.EstadoAudiencias;
using Sentir_Creativo_Backend.Audiencias.Persistence.Repositories.Origenes;
using Sentir_Creativo_Backend.Audiencias.Persistence.Repositories.Prefijos;

namespace Sentir_Creativo_Backend.Audiencias.Persistence;

public static class DependencyContainer
{
     public static IServiceCollection AddAudienciasPersistenceServices(this IServiceCollection services, IConfiguration configuration)
     {
          services.AddScoped<IAudienciaReadRepository, AudienciaReadRepository>();
          services.AddScoped<IAudienciaWriteRepository, AudienciaWriteRepository>();
          services.AddScoped<IOrigenReadRepository, OrigenReadRepository>();
          services.AddScoped<IOrigenWriteRepository, OrigenWriteRepository>();
          services.AddScoped<IEstadoAudienciaReadRepository, EstadoAudienciaReadRepository>();
          services.AddScoped<IEstadoAudienciaWriteRepository, EstadoAudienciaWriteRepository>();
          services.AddScoped<IPrefijoReadRepository, PrefijoReadRepository>();
          services.AddScoped<IPrefijoWriteRepository, PrefijoWriteRepository>();
          services.AddScoped<ICercaniaReadRepository, CercaniaReadRepository>();
          services.AddScoped<ICercaniaWriteRepository, CercaniaWriteRepository>();
          
          
          return services;
     }
}