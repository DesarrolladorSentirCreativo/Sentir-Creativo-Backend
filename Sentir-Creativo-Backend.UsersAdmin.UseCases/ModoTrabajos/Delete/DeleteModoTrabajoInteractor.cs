using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.Delete;

public class DeleteModoTrabajoInteractor : IDeleteModoTrabajoInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<ModoTrabajo,int> _readRepository;
    private readonly IDeleteModoTrabajoOutputPort _outputPort;
    
    public DeleteModoTrabajoInteractor(
        IUnitOfWork unitOfWork, IReadRepository<ModoTrabajo, int> readRepository,
        IDeleteModoTrabajoOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async  ValueTask Handle(int modoTrabajoId)
    {
        //buscamos el modo de trabajo
        var spec = new ModoTrabajoActivoByIdSpecification(modoTrabajoId);

        var modoTrabajo = await _readRepository.GetByIdWithSpec(spec);

        if (modoTrabajo == null) throw new NotFoundException("El modo de trabajo no se encuentra registrada");

        //cambiamos su estado a inactivo
        modoTrabajo.Activo = false;
        
        _unitOfWork.WriteRepository<ModoTrabajo,int>().UpdateEntity(modoTrabajo);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de modo de trabajo");
        }

        await _outputPort.Handle(modoTrabajo.Id);
    }
}