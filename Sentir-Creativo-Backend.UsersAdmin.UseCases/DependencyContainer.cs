using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios;
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
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.Create;
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
        services.AddScoped<ISelectCategoriaPrivilegioInputPort, SelectCategoriaPrivilegioInteractor>();
        
        //modulos
        services.AddScoped<ICreateModuloInputPort, CreateModuloInteractor>();
        services.AddScoped<IGetAllModuloInputPort, GetAllModuloInteractor>();
        services.AddScoped<IUpdateModuloInputPort, UpdateModuloInteractor>();
        services.AddScoped<IDeleteModuloInputPort, DeleteModuloInteractor>();
        services.AddScoped<IGetByIdModuloInputPort, GetByIdModuloInteractor>();
        services.AddScoped<ISelectModuloInputPort, SelectModuloInteractor>();
        
        //colecciones
        services.AddScoped<ICreateColeccionUserAdminInputPort, CreateColeccionUserAdminInteractor>();
        services.AddScoped<IGetAllColeccionUserAdminInputPort, GetAllColeccionUserAdminInteractor>();
        services.AddScoped<IUpdateColeccionUserAdminInputPort, UpdateColeccionUserAdminInteractor>();
        services.AddScoped<IDeleteColeccionUserAdminInputPort, DeleteColeccionUserAdminInteractor>();
        services.AddScoped<IGetByIdColeccionUserAdminInputPort, GetByIdColeccionUserAdminInteractor>();
        services.AddScoped<ISelectColeccionUserAdminInputPort, SelectColeccionUserAdminInteractor>();
        
        //privilegios
        services.AddScoped<ICreatePrivilegioInputPort, CreatePrivilegioInteractor>();
        
        return services;
    }
}