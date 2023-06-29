namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.Delete;

public class DeleteRolInteractor : IDeleteRolInputPort
{
    private readonly IReadRepository<Rol,int> _readRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDeleteRolOutputPort _outputPort;
    
    public DeleteRolInteractor(
        IReadRepository<Rol, int> readRepository,
        IUnitOfWork unitOfWork,
        IDeleteRolOutputPort outputPort)
    {
        _readRepository = readRepository;
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int rolId)
    {
        var spec = new RolActivoByIdSpecification(rolId);

        var rol = await _readRepository.GetByIdWithSpec(spec);

        if (rol == null) throw new NotFoundException("El rol no se encuentra registrada");

        //apagamos el rol
        rol.Activo = false;
        
        //guardamos el rol en la base de datos
        _unitOfWork.WriteRepository<Rol,int>().UpdateEntity(rol);
        
        //eliminamos los antiguos privilegios del rol
        _unitOfWork.WriteRepository<RolPrivilegio,int>().DeleteWhere(p => p.RolId == rolId);

        //eliminamos los antiguos los acuerdos del rol
        _unitOfWork.WriteRepository<RolAcuerdo,int>().DeleteWhere(p => p.RolId == rolId);
        
        //confirmamos los cambios en la base de datos
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de roles");
        }
        
        await _outputPort.Handle(rol.Id);
    }
}