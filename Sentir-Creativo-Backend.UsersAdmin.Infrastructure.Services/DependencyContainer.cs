using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Services;

namespace Sentir_Creativo_Backend.UsersAdmin.Infrastructure.Services;

public static class DependencyContainer
{
    public static IServiceCollection AddAdminUserInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IConfiguration>(configuration);
        services.AddScoped<IUserAdminTokenService, UserAdminTokenService>();
        
        return services;
    }
}