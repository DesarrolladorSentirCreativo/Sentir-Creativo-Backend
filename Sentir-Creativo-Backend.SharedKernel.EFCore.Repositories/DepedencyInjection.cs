using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.SharedKernel.EFCore.Repositories.Contexts;
using Sentir_Creativo_Backend.SharedKernel.EFCore.Repositories.Repositories;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.SharedKernel.EFCore.Repositories;

public static class DepedencyInjection
{
    public static IServiceCollection AddRepositoriesServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionMysqlString = configuration.GetConnectionString("MySqlConnection");

        
        services.AddDbContext<SentirCreativoDbContext>(options =>
            options.UseMySql(connectionMysqlString, ServerVersion.AutoDetect(connectionMysqlString)));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IReadRepository<,>), typeof(BaseReadRepository<,>));
        services.AddScoped(typeof(IWriteRepository<,>), typeof(BaseWriteRepository<,>));
        return services;
    }
}