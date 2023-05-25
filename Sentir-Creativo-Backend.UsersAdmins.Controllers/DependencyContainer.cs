using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.Sucursales;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.UserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddUserAdminControllers(this IServiceCollection services)
    {
        services.AddScoped<ILoginUserAdminController, LoginUserAdminController>();
        
        //sucursales
        services.AddScoped<ICreateSucursalController, CreateSucursalController>();
        services.AddScoped<IGetAllSucursalController, GetAllSucursalController>();
        services.AddScoped<IUpdateSucursalController, UpdateSucursalController>();
        services.AddScoped<IDeleteSucursalController, DeleteSucursalController>();
        services.AddScoped<IGetByIdSucursalController, GetByIdSucursalController>();
        services.AddScoped<ISelectSucursalController, SelectSucursalController>();
        
        //categorias privilegios
        services.AddScoped<ICreateCategoriaPrivilegioController, CreateCategoryPrivilegioController>();
        
        return services;
    }
}