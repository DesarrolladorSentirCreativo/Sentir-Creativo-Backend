using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.AdminUser;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.Modulos;
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
        
        services.AddScoped<UpdateCategoriaPrivilegioPresenter>();
        services.AddScoped<IUpdateCategoriaPrivilegioPresenter>(provider => provider.GetService<UpdateCategoriaPrivilegioPresenter>());
        services.AddScoped<IUpdateCategoriaPrivilegioOutputPort>(provider => provider.GetService<UpdateCategoriaPrivilegioPresenter>());
        
        services.AddScoped<DeleteCategoriaPrivilegioPresenter>();
        services.AddScoped<IDeleteCategoriaPrivilegioPresenter>(provider => provider.GetService<DeleteCategoriaPrivilegioPresenter>());
        services.AddScoped<IDeleteCategoriaPrivilegioOutputPort>(provider => provider.GetService<DeleteCategoriaPrivilegioPresenter>());
        
        services.AddScoped<GetByIdCategoriaPrivilegioPresenter>();
        services.AddScoped<IGetByIdCategoriaPrivilegioPresenter>(provider => provider.GetService<GetByIdCategoriaPrivilegioPresenter>());
        services.AddScoped<IGetByIdCategoriaPrivilegioOutputPort>(provider => provider.GetService<GetByIdCategoriaPrivilegioPresenter>());
        
        services.AddScoped<SelectCategoriaPrivilegioPresenter>();
        services.AddScoped<ISelectCategoriaPrivilegioPresenter>(provider => provider.GetService<SelectCategoriaPrivilegioPresenter>());
        services.AddScoped<ISelectCategoriaPrivilegioOutputPort>(provider => provider.GetService<SelectCategoriaPrivilegioPresenter>());
        
        //modulos
        services.AddScoped<CreateModuloPresenter>();
        services.AddScoped<ICreateModuloPresenter>(provider => provider.GetService<CreateModuloPresenter>());
        services.AddScoped<ICreateModuloOutputPort>(provider => provider.GetService<CreateModuloPresenter>());
        
        services.AddScoped<GetAllModuloPresenter>();
        services.AddScoped<IGetAllModuloPresenter>(provider => provider.GetService<GetAllModuloPresenter>());
        services.AddScoped<IGetAllModuloOutputPort>(provider => provider.GetService<GetAllModuloPresenter>());

        

        
        return services;
    }
}