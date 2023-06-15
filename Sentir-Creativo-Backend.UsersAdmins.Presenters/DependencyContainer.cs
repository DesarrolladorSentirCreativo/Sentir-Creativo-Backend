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
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Update;
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
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.AdminUser;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.AFP;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.Previsiones;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.Privilegios;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.Roles;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.UsuarioAdmins;

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

        services.AddScoped<UpdateModuloPresenter>();
        services.AddScoped<IUpdateModuloPresenter>(provider => provider.GetService<UpdateModuloPresenter>());
        services.AddScoped<IUpdateModuloOutputPort>(provider => provider.GetService<UpdateModuloPresenter>());
        
        services.AddScoped<DeleteModuloPresenter>();
        services.AddScoped<IDeleteModuloPresenter>(provider => provider.GetService<DeleteModuloPresenter>());
        services.AddScoped<IDeleteModuloOutputPort>(provider => provider.GetService<DeleteModuloPresenter>());
            
        services.AddScoped<GetByIdModuloPresenter>();
        services.AddScoped<IGetByIdModuloPresenter>(provider => provider.GetService<GetByIdModuloPresenter>());
        services.AddScoped<IGetByIdModuloOutputPort>(provider => provider.GetService<GetByIdModuloPresenter>());

        services.AddScoped<SelectModuloPresenter>();
        services.AddScoped<ISelectModuloPresenter>(provider => provider.GetService<SelectModuloPresenter>());
        services.AddScoped<ISelectModuloOutputPort>(provider => provider.GetService<SelectModuloPresenter>());
        
        services.AddScoped<GetAllWithColeccionesModuloPresenter>();
        services.AddScoped<IGetAllWithColeccionesModuloPresenter>(provider => provider.GetService<GetAllWithColeccionesModuloPresenter>());
        services.AddScoped<IGetAllWithColeccionesModuloOutputPort>(provider => provider.GetService<GetAllWithColeccionesModuloPresenter>());
        
        //colecciones
        services.AddScoped<CreateColeccionUserAdminPresenter>();
        services.AddScoped<ICreateColeccionUserAdminPresenter>(provider => provider.GetService<CreateColeccionUserAdminPresenter>());
        services.AddScoped<ICreateColeccionUserAdminOutputPort>(provider => provider.GetService<CreateColeccionUserAdminPresenter>());
        
        services.AddScoped<GetAllColeccionUserAdminPresenter>();
        services.AddScoped<IGetAllColeccionUserAdminPresenter>(provider => provider.GetService<GetAllColeccionUserAdminPresenter>());
        services.AddScoped<IGetAllColeccionUserAdminOutputPort>(provider => provider.GetService<GetAllColeccionUserAdminPresenter>());
        
        services.AddScoped<UpdateColeccionUserAdminPresenter>();
        services.AddScoped<IUpdateColeccionUserAdminPresenter>(provider => provider.GetService<UpdateColeccionUserAdminPresenter>());
        services.AddScoped<IUpdateColeccionUserAdminOutputPort>(provider => provider.GetService<UpdateColeccionUserAdminPresenter>());
        
        services.AddScoped<DeleteColeccionUserAdminPresenter>();
        services.AddScoped<IDeleteColeccionUserAdminPresenter>(provider => provider.GetService<DeleteColeccionUserAdminPresenter>());
        services.AddScoped<IDeleteColeccionUserAdminOutputPort>(provider => provider.GetService<DeleteColeccionUserAdminPresenter>());
        
        services.AddScoped<GetByIdColeccionUserAdminPresenter>();
        services.AddScoped<IGetByIdColeccionUserAdminPresenter>(provider => provider.GetService<GetByIdColeccionUserAdminPresenter>());
        services.AddScoped<IGetByIdColeccionUserAdminOutputPort>(provider => provider.GetService<GetByIdColeccionUserAdminPresenter>());
        
        services.AddScoped<SelectColeccionUserAdminPresenter>();
        services.AddScoped<ISelectColeccionUserAdminAdminPresenter>(provider => provider.GetService<SelectColeccionUserAdminPresenter>());
        services.AddScoped<ISelectColeccionUserAdminOutputPort>(provider => provider.GetService<SelectColeccionUserAdminPresenter>());
        
        //privilegios
        services.AddScoped<CreatePrivilegioPresenter>();
        services.AddScoped<ICreatePrivilegioPresenter>(provider => provider.GetService<CreatePrivilegioPresenter>());
        services.AddScoped<ICreatePrivilegioOutputPort>(provider => provider.GetService<CreatePrivilegioPresenter>());
        
        services.AddScoped<GetAllPrivilegioPresenter>();
        services.AddScoped<IGetAllPrivilegioPresenter>(provider => provider.GetService<GetAllPrivilegioPresenter>());
        services.AddScoped<IGetAllPrivilegioOutputPort>(provider => provider.GetService<GetAllPrivilegioPresenter>());
        
        services.AddScoped<UpdatePrivilegioPresenter>();
        services.AddScoped<IUpdatePrivilegioPresenter>(provider => provider.GetService<UpdatePrivilegioPresenter>());
        services.AddScoped<IUpdatePrivilegioOutputPort>(provider => provider.GetService<UpdatePrivilegioPresenter>());
        
        services.AddScoped<DeletePrivilegioPresenter>();
        services.AddScoped<IDeletePrivilegioPresenter>(provider => provider.GetService<DeletePrivilegioPresenter>());
        services.AddScoped<IDeletePrivilegioOutputPort>(provider => provider.GetService<DeletePrivilegioPresenter>());
        
        services.AddScoped<SelectPrivilegioPresenter>();
        services.AddScoped<ISelectPrivilegioPresenter>(provider => provider.GetService<SelectPrivilegioPresenter>());
        services.AddScoped<ISelectPrivilegioOutputPort>(provider => provider.GetService<SelectPrivilegioPresenter>());
        
        services.AddScoped<GetByIdPrivilegioPresenter>();
        services.AddScoped<IGetByIdPrivilegioPresenter>(provider => provider.GetService<GetByIdPrivilegioPresenter>());
        services.AddScoped<IGetByIdPrivilegioOutputPort>(provider => provider.GetService<GetByIdPrivilegioPresenter>());
        
        //acuerdos
        services.AddScoped<CreateAcuerdoUserAdminPresenter>();
        services.AddScoped<ICreateAcuerdoUserAdminPresenter>(provider => provider.GetService<CreateAcuerdoUserAdminPresenter>());
        services.AddScoped<ICreateAcuerdoUserAdminOutputPort>(provider => provider.GetService<CreateAcuerdoUserAdminPresenter>());
        
        services.AddScoped<GetAllAcuerdoUserAdminPresenter>();
        services.AddScoped<IGeAllAcuerdoUserAdminPresenter>(provider => provider.GetService<GetAllAcuerdoUserAdminPresenter>());
        services.AddScoped<IGetAllAcuerdoUserAdminOutputPort>(provider => provider.GetService<GetAllAcuerdoUserAdminPresenter>());
        
        services.AddScoped<UpdateAcuerdoUserAdminPresenter>();
        services.AddScoped<IUpdateAcuerdoUserAdminPresenter>(provider => provider.GetService<UpdateAcuerdoUserAdminPresenter>());
        services.AddScoped<IUpdateAcuerdoUserAdminOutputPort>(provider => provider.GetService<UpdateAcuerdoUserAdminPresenter>());
        
        services.AddScoped<DeleteAcuerdoUserAdminPresenter>();
        services.AddScoped<IDeleteAcuerdoUserAdminPresenter>(provider => provider.GetService<DeleteAcuerdoUserAdminPresenter>());
        services.AddScoped<IDeleteAcuerdoUserAdminOutputPort>(provider => provider.GetService<DeleteAcuerdoUserAdminPresenter>());
        
        services.AddScoped<GetByIdAcuerdoUserAdminPresenter>();
        services.AddScoped<IGetByIdAcuerdoUserAdminPresenter>(provider => provider.GetService<GetByIdAcuerdoUserAdminPresenter>());
        services.AddScoped<IGetByIdAcuerdoUserAdminOutputPort>(provider => provider.GetService<GetByIdAcuerdoUserAdminPresenter>());
        
        services.AddScoped<SelectAcuerdoUserAdminPresenter>();
        services.AddScoped<ISelectAcuerdoUserAdminPresenter>(provider => provider.GetService<SelectAcuerdoUserAdminPresenter>());
        services.AddScoped<ISelectAcuerdoUserAdminOutputPort>(provider => provider.GetService<SelectAcuerdoUserAdminPresenter>());
        
        //roles
        services.AddScoped<CreateRolPresenter>();
        services.AddScoped<ICreateRolPresenter>(provider => provider.GetService<CreateRolPresenter>());
        services.AddScoped<ICreateRolOutputPort>(provider => provider.GetService<CreateRolPresenter>());
        
        services.AddScoped<GetAllRolPresenter>();
        services.AddScoped<IGetAllRolPresenter>(provider => provider.GetService<GetAllRolPresenter>());
        services.AddScoped<IGetAllRolOutputPort>(provider => provider.GetService<GetAllRolPresenter>());
        
        services.AddScoped<UpdateRolPresenter>();
        services.AddScoped<IUpdateRolPresenter>(provider => provider.GetService<UpdateRolPresenter>());
        services.AddScoped<IUpdateRolOutputPort>(provider => provider.GetService<UpdateRolPresenter>());
        
        services.AddScoped<DeleteRolPresenter>();
        services.AddScoped<IDeleteRolPresenter>(provider => provider.GetService<DeleteRolPresenter>());
        services.AddScoped<IDeleteRolOutputPort>(provider => provider.GetService<DeleteRolPresenter>());
        
        services.AddScoped<GetByIdRolPresenter>();
        services.AddScoped<IGetByIdRolPresenter>(provider => provider.GetService<GetByIdRolPresenter>());
        services.AddScoped<IGetByIdRolOutputPort>(provider => provider.GetService<GetByIdRolPresenter>());
        
        services.AddScoped<SelectRolPresenter>();
        services.AddScoped<ISelectRolPresenter>(provider => provider.GetService<SelectRolPresenter>());
        services.AddScoped<ISelectRolOutputPort>(provider => provider.GetService<SelectRolPresenter>());
        
        //categorias
        services.AddScoped<CreateCategoriaUserAdminPresenter>();
        services.AddScoped<ICreateCategoriaUserAdminPresenter>(provider => provider.GetService<CreateCategoriaUserAdminPresenter>());
        services.AddScoped<ICreateCategoriaUserAdminOutputPort>(provider => provider.GetService<CreateCategoriaUserAdminPresenter>());
        
        services.AddScoped<GetAllCategoriaUserAdminPresenter>();
        services.AddScoped<IGetAllCategoriaUserAdminPresenter>(provider => provider.GetService<GetAllCategoriaUserAdminPresenter>());
        services.AddScoped<IGetAllCategoriaUserAdminOutputPort>(provider => provider.GetService<GetAllCategoriaUserAdminPresenter>());
        
        services.AddScoped<UpdateCategoriaUserAdminPresenter>();
        services.AddScoped<IUpdateCategoriaUserAdminPresenter>(provider => provider.GetService<UpdateCategoriaUserAdminPresenter>());
        services.AddScoped<IUpdateCategoriaUserAdminOutputPort>(provider => provider.GetService<UpdateCategoriaUserAdminPresenter>());
        
        services.AddScoped<DeleteCategoriaUserAdminPresenter>();
        services.AddScoped<IDeleteCategoriaUserAdminPresenter>(provider => provider.GetService<DeleteCategoriaUserAdminPresenter>());
        services.AddScoped<IDeleteCategoriaUserAdminOutputPort>(provider => provider.GetService<DeleteCategoriaUserAdminPresenter>());
        
        services.AddScoped<GetByIdCategoriaUserAdminPresenter>();
        services.AddScoped<IGetByIdCategoriaUserAdminPresenter>(provider => provider.GetService<GetByIdCategoriaUserAdminPresenter>());
        services.AddScoped<IGetByIdCategoriaUserAdminOutputPort>(provider => provider.GetService<GetByIdCategoriaUserAdminPresenter>());
        
        services.AddScoped<SelectCategoriaUserAdminPresenter>();
        services.AddScoped<ISelectCategoriaUserAdminPresenter>(provider => provider.GetService<SelectCategoriaUserAdminPresenter>());
        services.AddScoped<ISelectCategoriaUserAdminOutputPort>(provider => provider.GetService<SelectCategoriaUserAdminPresenter>());
        
        //afp
        services.AddScoped<CreateAfpPresenter>();
        services.AddScoped<ICreateAfpPresenter>(provider => provider.GetService<CreateAfpPresenter>());
        services.AddScoped<ICreateAfpOutputPort>(provider => provider.GetService<CreateAfpPresenter>());
        
        services.AddScoped<GetAllAfpPresenter>();
        services.AddScoped<IGetAllAfpPresenter>(provider => provider.GetService<GetAllAfpPresenter>());
        services.AddScoped<IGetAllAfpOutputPort>(provider => provider.GetService<GetAllAfpPresenter>());
        
        services.AddScoped<UpdateAfpPresenter>();
        services.AddScoped<IUpdateAfpPresenter>(provider => provider.GetService<UpdateAfpPresenter>());
        services.AddScoped<IUpdateAfpOutputPort>(provider => provider.GetService<UpdateAfpPresenter>());
        
        services.AddScoped<DeleteAfpPresenter>();
        services.AddScoped<IDeleteAfpPresenter>(provider => provider.GetService<DeleteAfpPresenter>());
        services.AddScoped<IDeleteAfpOutputPort>(provider => provider.GetService<DeleteAfpPresenter>());
        
        services.AddScoped<GetByIdAfpPresenter>();
        services.AddScoped<IGetByIdAfpPresenter>(provider => provider.GetService<GetByIdAfpPresenter>());
        services.AddScoped<IGetByIdAfpOutputPort>(provider => provider.GetService<GetByIdAfpPresenter>());
        
        services.AddScoped<SelectAfpPresenter>();
        services.AddScoped<ISelectAfpPresenter>(provider => provider.GetService<SelectAfpPresenter>());
        services.AddScoped<ISelectAfpOutputPort>(provider => provider.GetService<SelectAfpPresenter>());
        
        
        //modosTrabajos
        services.AddScoped<CreateModoTrabajoPresenter>();
        services.AddScoped<ICreateModoTrabajoPresenter>(provider => provider.GetService<CreateModoTrabajoPresenter>());
        services.AddScoped<ICreateModoTrabajoOutputPort>(provider => provider.GetService<CreateModoTrabajoPresenter>());
        
        services.AddScoped<GetAllModoTrabajoPresenter>();
        services.AddScoped<IGetAllModoTrabajoPresenter>(provider => provider.GetService<GetAllModoTrabajoPresenter>());
        services.AddScoped<IGetAllModoTrabajoOutputPort>(provider => provider.GetService<GetAllModoTrabajoPresenter>());
        
        services.AddScoped<UpdateModoTrabajoPresenter>();
        services.AddScoped<IUpdateModoTrabajoPresenter>(provider => provider.GetService<UpdateModoTrabajoPresenter>());
        services.AddScoped<IUpdateModoTrabajoOutputPort>(provider => provider.GetService<UpdateModoTrabajoPresenter>());
        
        services.AddScoped<DeleteModoTrabajoPresenter>();
        services.AddScoped<IDeleteModoTrabajoPresenter>(provider => provider.GetService<DeleteModoTrabajoPresenter>());
        services.AddScoped<IDeleteModoTrabajoOutputPort>(provider => provider.GetService<DeleteModoTrabajoPresenter>());
        
        services.AddScoped<GetByIdModoTrabajoPresenter>();
        services.AddScoped<IGetByIdModoTrabajoPresenter>(provider => provider.GetService<GetByIdModoTrabajoPresenter>());
        services.AddScoped<IGetByIdModoTrabajoOutputPort>(provider => provider.GetService<GetByIdModoTrabajoPresenter>());
        
        services.AddScoped<SelectModoTrabajoPresenter>();
        services.AddScoped<ISelectModoTrabajoPresenter>(provider => provider.GetService<SelectModoTrabajoPresenter>());
        services.AddScoped<ISelectModoTrabajoOutputPort>(provider => provider.GetService<SelectModoTrabajoPresenter>());
        
        //previsiones
        services.AddScoped<CreatePrevisionPresenter>();
        services.AddScoped<ICreatePrevisionPresenter>(provider => provider.GetService<CreatePrevisionPresenter>());
        services.AddScoped<ICreatePrevisionOutputPort>(provider => provider.GetService<CreatePrevisionPresenter>());
        
        services.AddScoped<GetAllPrevisionPresenter>();
        services.AddScoped<IGetAllPrevisionPresenter>(provider => provider.GetService<GetAllPrevisionPresenter>());
        services.AddScoped<IGetAllPrevisionOutputPort>(provider => provider.GetService<GetAllPrevisionPresenter>());
        
        services.AddScoped<UpdatePrevisionPresenter>();
        services.AddScoped<IUpdatePrevisionPresenter>(provider => provider.GetService<UpdatePrevisionPresenter>());
        services.AddScoped<IUpdatePrevisionOutputPort>(provider => provider.GetService<UpdatePrevisionPresenter>());
        
        services.AddScoped<DeletePrevisionPresenter>();
        services.AddScoped<IDeletePrevisionPresenter>(provider => provider.GetService<DeletePrevisionPresenter>());
        services.AddScoped<IDeletePrevisionOutputPort>(provider => provider.GetService<DeletePrevisionPresenter>());
        
        services.AddScoped<GetByIdPrevisionPresenter>();
        services.AddScoped<IGetByIdPrevisionPresenter>(provider => provider.GetService<GetByIdPrevisionPresenter>());
        services.AddScoped<IGetByIdPrevisionOutputPort>(provider => provider.GetService<GetByIdPrevisionPresenter>());
        
        services.AddScoped<SelectPrevisionPresenter>();
        services.AddScoped<ISelectPrevisionPresenter>(provider => provider.GetService<SelectPrevisionPresenter>());
        services.AddScoped<ISelectPrevisionOutputPort>(provider => provider.GetService<SelectPrevisionPresenter>());
        
        //estados useradmins
        
        services.AddScoped<CreateEstadoUserAdminPresenter>();
        services.AddScoped<ICreateEstadoUserAdminPresenter>(provider => provider.GetService<CreateEstadoUserAdminPresenter>());
        services.AddScoped<ICreateEstadoUserAdminOutputPort>(provider => provider.GetService<CreateEstadoUserAdminPresenter>());
        
        services.AddScoped<GetAllEstadoUserAdminPresenter>();
        services.AddScoped<IGetAllEstadoUserAdminPresenter>(provider => provider.GetService<GetAllEstadoUserAdminPresenter>());
        services.AddScoped<IGetAllEstadoUserAdminOutputPort>(provider => provider.GetService<GetAllEstadoUserAdminPresenter>());
        
        services.AddScoped<UpdateEstadoUserAdminPresenter>();
        services.AddScoped<IUpdateEstadoUserAdminPresenter>(provider => provider.GetService<UpdateEstadoUserAdminPresenter>());
        services.AddScoped<IUpdateEstadoUserAdminOutputPort>(provider => provider.GetService<UpdateEstadoUserAdminPresenter>());
        
        services.AddScoped<DeleteEstadoUserAdminPresenter>();
        services.AddScoped<IDeleteEstadoUserAdminPresenter>(provider => provider.GetService<DeleteEstadoUserAdminPresenter>());
        services.AddScoped<IDeleteEstadoUserAdminOutputPort>(provider => provider.GetService<DeleteEstadoUserAdminPresenter>());
        
        services.AddScoped<GetByIdEstadoUserAdminPresenter>();
        services.AddScoped<IGetByIdEstadoUserAdminPresenter>(provider => provider.GetService<GetByIdEstadoUserAdminPresenter>());
        services.AddScoped<IGetByIdEstadoUserAdminOutputPort>(provider => provider.GetService<GetByIdEstadoUserAdminPresenter>());
        
        services.AddScoped<SelectEstadoUserAdminPresenter>();
        services.AddScoped<ISelectEstadoUserAdminPresenter>(provider => provider.GetService<SelectEstadoUserAdminPresenter>());
        services.AddScoped<ISelectEstadoUserAdminOutputPort>(provider => provider.GetService<SelectEstadoUserAdminPresenter>());
        
        //usuarios admins
        services.AddScoped<CreateUsuarioAdminPresenter>();
        services.AddScoped<ICreateUsuarioAdminPresenter>(provider => provider.GetService<CreateUsuarioAdminPresenter>());
        services.AddScoped<ICreateUsuarioAdminOutputPort>(provider => provider.GetService<CreateUsuarioAdminPresenter>());
        
        services.AddScoped<GetAllUsuarioAdminPresenter>();
        services.AddScoped<IGetAllUsuarioAdminPresenter>(provider => provider.GetService<GetAllUsuarioAdminPresenter>());
        services.AddScoped<IGetAllUsuarioAdminOutputPort>(provider => provider.GetService<GetAllUsuarioAdminPresenter>());
        
        services.AddScoped<UpdateUsuarioAdminPresenter>();
        services.AddScoped<IUpdateUsuarioAdminPresenter>(provider => provider.GetService<UpdateUsuarioAdminPresenter>());
        services.AddScoped<IUpdateUsuarioAdminOutputPort>(provider => provider.GetService<UpdateUsuarioAdminPresenter>());

        return services;
    }
}