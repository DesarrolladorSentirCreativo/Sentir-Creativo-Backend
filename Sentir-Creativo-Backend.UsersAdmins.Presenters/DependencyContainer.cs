using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.AdminUser;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddUserAdminPresenters(this IServiceCollection services)
    {
        services.AddScoped<LoginUserAdminPresenter>();
        services.AddScoped<ILoginUserAdminPresenter>(provider => provider.GetService<LoginUserAdminPresenter>());
        services.AddScoped<ILoginUserAdminOutputPort>(provider => provider.GetService<LoginUserAdminPresenter>());
        
        //sucursales
        services.AddScoped<CreateSucursalPresenter>();
        services.AddScoped<ICreateSucursalPresenter>(provider => provider.GetService<CreateSucursalPresenter>());
        services.AddScoped<ICreateSucursalOutputPort>(provider => provider.GetService<CreateSucursalPresenter>());
        
        services.AddScoped<GetAllSucursalPresenter>();
        services.AddScoped<IGetAllSucursalPresenter>(provider => provider.GetService<GetAllSucursalPresenter>());
        services.AddScoped<IGetAllSucursalOutputPort>(provider => provider.GetService<GetAllSucursalPresenter>());

        
        return services;
    }
}