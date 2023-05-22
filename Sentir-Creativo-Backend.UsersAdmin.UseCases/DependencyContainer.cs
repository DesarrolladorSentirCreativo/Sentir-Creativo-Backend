using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.UserAdmin.Login;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddUsersAdminUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ILoginUserAdminInputPort, LoginUserAdminInteractor>();
        
        //sucursales
        services.AddScoped<ICreateSucursalInputPort, CreateSucursalInteractor>();
        services.AddScoped<IGetAllSucursalInputPort, GetAllSucursalInteractor>();
        services.AddScoped<IUpdateSucursalInputPort, UpdateSucursalInteractor>();
        
        return services;
    }
}