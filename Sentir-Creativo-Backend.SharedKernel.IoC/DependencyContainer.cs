using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.SharedKernel.EFCore.Repositories;

namespace Sentir_Creativo_Backend.SharedKernel.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddSharedKernelRepositoriesServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddRepositoriesServices(configuration);
        
        return services;
        
    }
}