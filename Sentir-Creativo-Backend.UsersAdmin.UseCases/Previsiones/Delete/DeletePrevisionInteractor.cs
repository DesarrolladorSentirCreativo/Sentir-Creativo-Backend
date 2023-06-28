using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.Delete;

public class DeletePrevisionInteractor : IDeletePrevisionInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Prevision,int> _readRepository;
    private readonly IDeletePrevisionOutputPort _outputPort;
    
    public DeletePrevisionInteractor(
        IUnitOfWork unitOfWork, IReadRepository<Prevision, int> readRepository,
        IDeletePrevisionOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int previsionId)
    {
        var spec = new PrevisionActivoByIdSpecification(previsionId);

        var prevision = await _readRepository.GetByIdWithSpec(spec);

        if (prevision == null) throw new NotFoundException("El prevision no se encuentra registrado");

        prevision.Activo = false;
        
        _unitOfWork.WriteRepository<Prevision,int>().UpdateEntity(prevision);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de prevision");
        }

        await _outputPort.Handle(prevision.Id);
    }
}