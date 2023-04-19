using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.AdminUser;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddUserAdminPresenters(this IServiceCollection services)
    {
        services.AddScoped<LoginUserAdminPresenter>();
        services.AddScoped<ILoginUserAdminPresenter>(provider => provider.GetService<LoginUserAdminPresenter>());
        services.AddScoped<ILoginUserAdminOutputPort>(provider => provider.GetService<LoginUserAdminPresenter>());
        
        return services;
    }
}