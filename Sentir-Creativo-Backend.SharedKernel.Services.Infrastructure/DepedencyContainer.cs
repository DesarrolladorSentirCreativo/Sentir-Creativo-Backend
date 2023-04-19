using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Services.Infrastructure.Services;

namespace Sentir_Creativo_Backend.SharedKernel.Services.Infrastructure;

public static class DepedencyContainer
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IHashPassword, HashPassword>();
        return services;
    }
}