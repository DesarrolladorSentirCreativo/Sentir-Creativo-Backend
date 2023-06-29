namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.AcuerdosUserAdmin.Delete;

public class DeleteAcuerdoUserAdminInteractor : IDeleteAcuerdoUserAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<AcuerdoUserAdmin,int> _readRepository;
    private readonly IDeleteAcuerdoUserAdminOutputPort _outputPort;

    public DeleteAcuerdoUserAdminInteractor(
        IUnitOfWork unitOfWork, 
        IReadRepository<AcuerdoUserAdmin, int> readRepository,
        IDeleteAcuerdoUserAdminOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle(int acuerdoId)
    {
        
        var spec = new AcuerdoUserAdminActivoByIdSpecification(acuerdoId);

        var acuerdo = await _readRepository.GetByIdWithSpec(spec);

        if (acuerdo == null) throw new Exception("El acuerdo no se encuentra registrada");

        acuerdo.Activo = false;
        
        _unitOfWork.WriteRepository<AcuerdoUserAdmin,int>().UpdateEntity(acuerdo);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de acuerdos");
        }

        await _outputPort.Handle(acuerdo.Id);
    }
}