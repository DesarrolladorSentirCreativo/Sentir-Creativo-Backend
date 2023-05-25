using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.Select;
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
        services.AddScoped<IDeleteSucursalInputPort, DeleteSucursalInteractor>();
        services.AddScoped<IGetByIdSucursalInputPort, GetByIdSucursalInteractor>();
        services.AddScoped<ISelectSucursalInputPort, SelectSucursalInteractor>();
        
        //categorias privilegios
        services.AddScoped<ICreateCategoriaPrivilegioInputPort, CreateCategoriaPrivilegioInteractor>();
        services.AddScoped<IGetAllCategoriaPrivilegioInputPort, GetAllCategoriaPrivilegioInteractor>();
        services.AddScoped<IUpdateCategoriaPrivilegioInputPort, UpdateCategoriaPrivilegioInteractor>();
        services.AddScoped<IDeleteCategoriaPrivilegioInputPort, DeleteCategoriaPrivilegioInteractor>();
        services.AddScoped<IGetByIdCategoriaPrivilegioInputPort, GetByIdCategoriaPrivilegioInteractor>();
        
        return services;
    }
}