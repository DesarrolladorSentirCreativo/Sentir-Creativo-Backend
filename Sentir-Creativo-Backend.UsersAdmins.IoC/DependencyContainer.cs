using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.Infrastructure.Services;
using Sentir_Creativo_Backend.UsersAdmin.UseCases;
using Sentir_Creativo_Backend.UsersAdmins.Controllers;
using Sentir_Creativo_Backend.UsersAdmins.Presenters;

namespace Sentir_Creativo_Backend.UsersAdmins.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddUserAdminServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddUserAdminControllers();
        services.AddAdminUserInfrastructureServices(configuration);
        services.AddUsersAdminUseCasesServices();
        services.AddUserAdminPresenters();

        return services;
    }
}