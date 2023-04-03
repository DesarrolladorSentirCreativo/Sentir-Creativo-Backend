using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Sentir_Creativo_Backend.Application.Mappers;

public static class DependencyInjection
{
    public static IServiceCollection AddMappingServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(typeof(MappingProfile));
        
        return services;
    }
}