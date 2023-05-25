using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.AdminUser;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaPrivilegios;
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
        
        services.AddScoped<UpdateSucursalPresenter>();
        services.AddScoped<IUpdateSucursalPresenter>(provider => provider.GetService<UpdateSucursalPresenter>());
        services.AddScoped<IUpdateSucursalOutputPort>(provider => provider.GetService<UpdateSucursalPresenter>());
        
        services.AddScoped<UpdateSucursalPresenter>();
        services.AddScoped<IUpdateSucursalPresenter>(provider => provider.GetService<UpdateSucursalPresenter>());
        services.AddScoped<IUpdateSucursalOutputPort>(provider => provider.GetService<UpdateSucursalPresenter>());
        
        services.AddScoped<DeleteSucursalPresenter>();
        services.AddScoped<IDeleteSucursalPresenter>(provider => provider.GetService<DeleteSucursalPresenter>());
        services.AddScoped<IDeleteSucursalOutputPort>(provider => provider.GetService<DeleteSucursalPresenter>());
        
        services.AddScoped<GetByIdSucursalPresenter>();
        services.AddScoped<IGetByIdSucursalPresenter>(provider => provider.GetService<GetByIdSucursalPresenter>());
        services.AddScoped<IGetByIdSucursalOutputPort>(provider => provider.GetService<GetByIdSucursalPresenter>());
        
        services.AddScoped<SelectSucursalPresenter>();
        services.AddScoped<ISelectSucursalPresenter>(provider => provider.GetService<SelectSucursalPresenter>());
        services.AddScoped<ISelectSucursalOutputPort>(provider => provider.GetService<SelectSucursalPresenter>());
        
        //categorias privilegios
        services.AddScoped<CreateCategoriaPrivilegioPresenter>();
        services.AddScoped<ICreateCategoriaPrivilegioPresenter>(provider => provider.GetService<CreateCategoriaPrivilegioPresenter>());
        services.AddScoped<ICreateCategoriaPrivilegioOutputPort>(provider => provider.GetService<CreateCategoriaPrivilegioPresenter>());
        
        services.AddScoped<GetAllCategoriaPrivilegioPresenter>();
        services.AddScoped<IGetAllCategoriaPrivilegioPresenter>(provider => provider.GetService<GetAllCategoriaPrivilegioPresenter>());
        services.AddScoped<IGetAllCategoriaPrivilegioOutputPort>(provider => provider.GetService<GetAllCategoriaPrivilegioPresenter>());

        
        return services;
    }
}