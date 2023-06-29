namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.AFP.Delete;

public class DeleteAfpInteractor : IDeleteAfpInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Afp,int> _readRepository;
    private readonly IDeleteAfpOutputPort _outputPort;
    
    public DeleteAfpInteractor(
        IUnitOfWork unitOfWork, IReadRepository<Afp, int> readRepository,
        IDeleteAfpOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle(int afpId)
    {
        var spec = new AfpActivoByIdSpecification(afpId);

        var afp = await _readRepository.GetByIdWithSpec(spec);

        if (afp == null) throw new NotFoundException("El afp no se encuentra registrada");

        afp.Activo = false;
        
        _unitOfWork.WriteRepository<Afp,int>().UpdateEntity(afp);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de afp");
        }

        await _outputPort.Handle(afp.Id);
    }
}