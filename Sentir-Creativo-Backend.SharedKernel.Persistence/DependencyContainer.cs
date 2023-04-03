using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.SharedKernel.Persistence.Contexts;

namespace Sentir_Creativo_Backend.SharedKernel.Persistence;

public static class DependencyContainer
{
     public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
          IConfiguration configuration)
     {
          var connectionMysqlString = configuration.GetConnectionString("MySqlConnection");

          services.AddDbContext<SentirCreativoDbContext>(options =>
               options.UseMySql(connectionMysqlString, ServerVersion.AutoDetect(connectionMysqlString)));
          
          return services;
     }
}