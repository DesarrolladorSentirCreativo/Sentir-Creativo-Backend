namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.EstadoUserAdmins.Delete;

public class DeleteEstadoUserAdminInteractor : IDeleteEstadoUserAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDeleteEstadoUserAdminOutputPort _outputPort;
    private readonly IReadRepository<EstadoUserAdmin, int> _readRepository;
    
    public DeleteEstadoUserAdminInteractor(IUnitOfWork unitOfWork, 
        IDeleteEstadoUserAdminOutputPort outputPort,
        IReadRepository<EstadoUserAdmin, int> readRepository)
    {
        _outputPort = outputPort;
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
    }
    
    public async ValueTask Handle(int estadoId)
    {
        var spec = new EstadoUserAdminActivoByIdSpecification(estadoId);

        var estadoUserAdmin = await _readRepository.GetByIdWithSpec(spec);

        if (estadoUserAdmin == null) throw new NotFoundException("El estado de useradmin no se encuentra registrado");

        estadoUserAdmin.Activo = false;
        
        _unitOfWork.WriteRepository<EstadoUserAdmin,int>().UpdateEntity(estadoUserAdmin);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de estados useradmins");
        }

        await _outputPort.Handle(estadoUserAdmin.Id);
    }
}