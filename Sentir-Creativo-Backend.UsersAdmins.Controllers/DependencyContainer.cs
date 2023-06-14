using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.AFP;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.Modulos;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.Previsiones;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.Privilegios;
using Sentir_Creativo_Backend.UsersAdmins.Controllers.Roles;
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
        services.AddScoped<IGetAllCategoriaPrivilegioController, GetAllCategoriaPrivilegioController>();
        services.AddScoped<IUpdateCategoriaPrivilegioController, UpdateCategoriaPrivilegioController>();
        services.AddScoped<IDeleteCategoriaPrivilegioController, DeleteCategoriaPrivilegioController>();
        services.AddScoped<IGetByIdCategoriaPrivilegioController, GetByIdCategoriaPrivilegioController>();
        services.AddScoped<ISelectCategoriaPrivilegioController, SelectCategoriaPrivilegioController>();
        
        //modulos
        services.AddScoped<ICreateModuloController, CreateModuloController>();
        services.AddScoped<IGetAllModuloController, GetAllModuloController>();
        services.AddScoped<IUpdateModuloController, UpdateModuloController>();
        services.AddScoped<IDeleteModuloController, DeleteModuloController>();
        services.AddScoped<IGetByIdModuloController, GetByIdModuloController>();
        services.AddScoped<ISelectModuloController, SelectModuloController>();
        services.AddScoped<IGetAllWithColeccionesModuloController, GetAllWithColeccionesModuloController>();
        
        //colecciones
        services.AddScoped<ICreateColeccionUserAdminController, CreateColeccionUserAdminController>();
        services.AddScoped<IGetAllColeccionUserAdminController, GetAllColeccionUserAdminController>();
        services.AddScoped<IUpdateColeccionUserAdminController, UpdateColeccionUserAdminController>();
        services.AddScoped<IDeleteColeccionUserAdminController, DeleteColeccionUserAdminController>();
        services.AddScoped<IGetByIdColeccionUserAdminController, GetByIdColeccionUserAdminController>();
        services.AddScoped<ISelectColeccionUserAdminController, SelectColeccionUserAdminController>();
        
        //privilegios
        services.AddScoped<ICreatePrivilegioController, CreatePrivilegioController>();
        services.AddScoped<IGetAllPrivilegioController, GetAllPrivilegioController>();
        services.AddScoped<IUpdatePrivilegioController, UpdatePrivilegioController>();
        services.AddScoped<IDeletePrivilegioController, DeletePrivilegioController>();
        services.AddScoped<ISelectPrivilegioController, SelectPrivilegioController>();
        services.AddScoped<IGetByIdPrivilegioController, GetByIdPrivilegioController>();
        
        //acuerdos
        services.AddScoped<ICreateAcuerdoUserAdminController, CreateAcuerdoUserAdminController>();
        services.AddScoped<IGetAllAcuerdoUserAdminController, GetAllAcuerdoUserAdminController>();
        services.AddScoped<IUpdateAcuerdoUserAdminController, UpdateAcuerdoUserAdminController>();
        services.AddScoped<IDeleteAcuerdoUserAdminController, DeleteAcuerdoUserAdminController>();
        services.AddScoped<IGetByIdAcuerdoUserAdminControiller, GetByIdAcuerdoUserAdminController>();
        services.AddScoped<ISelectAcuerdoUserAdminController, SelectAcuerdoUserAdminController>();
        
        //roles
        services.AddScoped<ICreateRolController, CreateRolController>();
        services.AddScoped<IGetAllRolController, GetAllRolController>();
        services.AddScoped<IUpdateRolController, UpdateRolController>();
        services.AddScoped<IDeleteRolController, DeleteRolController>();
        services.AddScoped<IGetByIdRolController, GetByIdRolController>();
        services.AddScoped<ISelectRolController, SelectRolController>();
        
        //categorias
        services.AddScoped<ICreateCategoriaUserAdminController, CreateCategoriaUserAdminController>();
        services.AddScoped<IGetAllCategoriaUserAdminController, GetAllCategoriaUserAdminController>();
        services.AddScoped<IUpdateCategoriaUserAdminController, UpdateCategoriaUserAdminController>();
        services.AddScoped<IDeleteCategoriaUserAdminController, DeleteCategoriaUserAdminController>();
        services.AddScoped<IGetByIdCategoriaUserAdminController, GetByIdCategoriaUserAdminController>();
        services.AddScoped<ISelectCategoriaUserAdminController, SelectCategoriaUserAdminController>();
        
        //afp
        services.AddScoped<ICreateAfpController, CreateAfpController>();
        services.AddScoped<IGetAllAfpController, GetAllAfpController>();
        services.AddScoped<IUpdateAfpController, UpdateAfpController>();
        services.AddScoped<IDeleteAfpController, DeleteAfpController>();
        services.AddScoped<IGetByIdAfpController, GetByIdAfpController>();
        services.AddScoped<ISelectAfpController, SelectAfpController>();
        
        //modosTrabajos
        services.AddScoped<ICreateModoTrabajoController, CreateModoTrabajoController>();
        services.AddScoped<IGetAllModoTrabajoController, GetAllModoTrabajoController>();
        services.AddScoped<IUpdateModoTrabajoController, UpdateModoTrabajoController>();
        services.AddScoped<IDeleteModoTrabajoController, DeleteModoTrabajoController>();
        services.AddScoped<IGetByIdModoTrabajoController, GetByIdModoTrabajoController>();
        services.AddScoped<ISelectModoTrabajoController, SelectModoTrabajoController>();
        
        //previsiones
        services.AddScoped<ICreatePrevisionController, CreatePrevisionController>();
        services.AddScoped<IGetAllPrevisionController, GetAllPrevisionController>();
        services.AddScoped<IUpdatePrevisionController, UpdatePrevisionController>();
        services.AddScoped<IDeletePrevisionController, DeletePrevisionController>();
        services.AddScoped<IGetByIdPrevisionController, GetByIdPrevisionController>();
        services.AddScoped<ISelectPrevisionController, SelectPrevisionController>();
        
        //estados useradmins
        services.AddScoped<ICreateEstadoUserAdminController, CreateEstadoUserAdminController>();
        services.AddScoped<IGetAllEstadoUserAdminController, GetAllEstadoUserAdminController>();
        services.AddScoped<IUpdateEstadoUserAdminController, UpdateEstadoUserAdminController>();
        services.AddScoped<IDeleteEstadoUserAdminController, DeleteEstadoUserAdminController>();
        services.AddScoped<IGetByIdEstadoUserAdminController, GetByIdEstadoUserAdminController>();
        services.AddScoped<ISelectEstadoUserAdminController, SelectEstadoUserAdminController>();
        
        return services;
    }
}