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
        
        //estados useradmisn
        services.AddScoped<ICreateEstadoUserAdminInputPort, CreateEstadoUserAdminInteractor>();
        services.AddScoped<IGetAllEstadoUserAdminInputPort, GetAllEstadoUserAdminInteractor>();
        services.AddScoped<IDeleteEstadoUserAdminInputPort, DeleteEstadoUserAdminInteractor>();
        services.AddScoped<IUpdateEstadoUserAdminInputPort, UpdateEstadoUserAdminInteractor>();
        services.AddScoped<IGetByIdEstadoUserAdminInputPort, GetByIdEstadoUserAdminInteractor>();
        services.AddScoped<ISelectEstadoUserAdminInputPort, SelectEstadoUserAdminInteractor>();
        
        //usuarios admins
        services.AddScoped<ICreateUsuarioAdminInputPort, CreateUsuarioAdminInteractor>();
        services.AddScoped<IGetAllUsuarioAdminInputPort, GetAllUsuarioAdminInteractor>();
        services.AddScoped<IUpdateUsuarioAdminInputPort, UpdateUsuarioAdminInteractor>();
        services.AddScoped<IDeleteUsuarioAdminInputPort, DeleteUsuarioAdminInteractor>();
        services.AddScoped<IGetByIdUsuarioAdminInputPort, GetByIdUsuarioAdminInteractor>();
        services.AddScoped<ISelectUsuarioAdminInputPort, SelectUsuarioAdminInteractor>();
        services.AddScoped<ILoginUsuarioAdminInputPort, LoginUsuarioAdminInteractor>();

        return services;
    }
}