using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetAllWithColecciones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.AcuerdosUserAdmin.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.AcuerdosUserAdmin.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.AcuerdosUserAdmin.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.AcuerdosUserAdmin.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.AcuerdosUserAdmin.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.AcuerdosUserAdmin.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.AFP.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.AFP.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.AFP.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.AFP.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.AFP.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.AFP.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaUserAdmins.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaUserAdmins.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaUserAdmins.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaUserAdmins.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaUserAdmins.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaUserAdmins.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.GetAllWithColeccionesModulo;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.Create;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.Delete;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.GetById;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.Select;
using Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.Update;
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
        services.AddScoped<IGetAllWithColeccionesModuloInputPort, GetAllWithColeccionesModuloInteractor>();

        //colecciones
        services.AddScoped<ICreateColeccionUserAdminInputPort, CreateColeccionUserAdminInteractor>();
        services.AddScoped<IGetAllColeccionUserAdminInputPort, GetAllColeccionUserAdminInteractor>();
        services.AddScoped<IUpdateColeccionUserAdminInputPort, UpdateColeccionUserAdminInteractor>();
        services.AddScoped<IDeleteColeccionUserAdminInputPort, DeleteColeccionUserAdminInteractor>();
        services.AddScoped<IGetByIdColeccionUserAdminInputPort, GetByIdColeccionUserAdminInteractor>();
        services.AddScoped<ISelectColeccionUserAdminInputPort, SelectColeccionUserAdminInteractor>();
        
        //privilegios
        services.AddScoped<ICreatePrivilegioInputPort, CreatePrivilegioInteractor>();
        services.AddScoped<IGetAllPrivilegioInputPort, GetAllPrivilegioInteractor>();
        services.AddScoped<IUpdatePrivilegioInputPort, UpdatePrivilegioInteractor>();
        services.AddScoped<IDeletePrivilegioInputPort, DeletePrivilegioInteractor>();
        services.AddScoped<ISelectPrivilegioInputPort, SelectPrivilegioInteractor>();
        services.AddScoped<IGetByIdPrivilegioInputPort, GetByIdPrivilegioInteractor>();
        
        //acuerdos
        services.AddScoped<ICreateAcuerdoUserAdminInputPort, CreateAcuerdoUserAdminInteractor>();
        services.AddScoped<IGetAllAcuerdoUserAdminInputPort, GetAllAcuerdoUserAdminInteractor>();
        services.AddScoped<IUpdateAcuerdoUserAdminInputPort, UpdateAcuerdoUserAdminInteractor>();
        services.AddScoped<IDeleteAcuerdoUserAdminInputPort, DeleteAcuerdoUserAdminInteractor>();
        services.AddScoped<IGetByIdAcuerdoUserAdminInputPort, GetByIdAcuerdoUserAdminInteractor>();
        services.AddScoped<ISelectAcuerdoUserAdminInputPort, SelectAcuerdoUserAdminInteractor>();
        
        //roles
        services.AddScoped<ICreateRolInputPort, CreateRolInteractor>();
        services.AddScoped<IGetAllRolInputPort, GetAllRolInteractor>();
        services.AddScoped<IUpdateRolInputPort, UpdateRolInteractor>();
        services.AddScoped<IDeleteRolInputPort, DeleteRolInteractor>();
        services.AddScoped<IGetByIdRolInputPort, GetByIdRolInteractor>();
        services.AddScoped<ISelectRolInputPort, SelectRolInteractor>();
        
        //categorias useradmins
        services.AddScoped<ICreateCategoriaUserAdminInputPort, CreateCategoriaUserAdminInteractor>();
        services.AddScoped<IGetAllCategoriaUserAdminInputPort, GetAllCategoriaUserAdminInteractor>();
        services.AddScoped<IUpdateCategoriaUserAdminInputPort, UpdateCategoriaUserAdminInteractor>();
        services.AddScoped<IDeleteCategoriaUserAdminInputPort, DeleteCategoriaUserAdminInteractor>();
        services.AddScoped<IGetByIdCategoriaUserAdminInputPort, GetByIdCategoriaUserAdminInteractor>();
        services.AddScoped<ISelectCategoriaUserAdminInputPort, SelectCategoriaUserAdminInteractor>();
        
        //afp
        services.AddScoped<ICreateAfpInputPort, CreateAfpInteractor>();
        services.AddScoped<IGetAllAfpInputPort, GetAllAfpInteractor>();
        services.AddScoped<IDeleteAfpInputPort, DeleteAfpInteractor>();
        services.AddScoped<IUpdateAfpInputPort, UpdateAfpInteractor>();
        services.AddScoped<IGetByIdAfpInputPort, GetByIdAfpInteractor>();
        services.AddScoped<ISelectAfpInputPort, SelectAfpInteractor>();
        
        //modosTrabajos
        services.AddScoped<ICreateModoTrabajoInputPort, CreateModoTrabajoInteractor>();
        services.AddScoped<IGetAllModoTrabajoInputPort, GetAllModoTrabajoInteractor>();
        services.AddScoped<IDeleteModoTrabajoInputPort, DeleteModoTrabajoInteractor>();
        services.AddScoped<IUpdateModoTrabajoInputPort, UpdateModoTrabajoInteractor>();
        services.AddScoped<IGetByIdModoTrabajoInputPort, GetByIdModoTrabajoInteractor>();
        services.AddScoped<ISelectModoTrabajoInputPort, SelectModoTrabajoInteractor>();
        
        //previsiones
        services.AddScoped<ICreatePrevisionInputPort, CreatePrevisionInteractor>();
        services.AddScoped<IGetAllPrevisionInputPort, GetAllPrevisionInteractor>();
        services.AddScoped<IDeletePrevisionInputPort, DeletePrevisionInteractor>();
        services.AddScoped<IUpdatePrevisionInputPort, UpdatePrevisionInteractor>();
        services.AddScoped<IGetByIdPrevisionInputPort, GetByIdPrevisionInteractor>();
        services.AddScoped<ISelectPrevisionInputPort, SelectPrevisionInteractor>();

        return services;
    }
}