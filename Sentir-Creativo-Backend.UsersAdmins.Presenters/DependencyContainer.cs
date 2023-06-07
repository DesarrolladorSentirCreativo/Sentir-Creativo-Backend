using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Create;
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
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetAllWithColecciones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.AdminUser;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.Privilegios;
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

        return services;
    }
}