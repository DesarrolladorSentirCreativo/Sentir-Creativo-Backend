using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Delete;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.Delete;

public class DeleteAudienciaInteractor : IDeleteAudienciaInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Entities.POCOEntities.Audiencia,int> _readRepository;
    private readonly IDeleteAudienciaOutputPort _outputPort;

    public DeleteAudienciaInteractor(
        IUnitOfWork unitOfWork,
        IReadRepository<Entities.POCOEntities.Audiencia, int> readRepository,
        IDeleteAudienciaOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle(int audienciaId)
    {
        var audiencia = await _readRepository.GetByIdAsync(audienciaId);

        if (audiencia == null) throw new Exception("La audiencia no se encuentra registrada");

        audiencia.Activo = false;
        
        _unitOfWork.WriteRepository<Entities.POCOEntities.Audiencia,int>().UpdateEntity(audiencia);

        await _unitOfWork.Complete();

        await _outputPort.Handle(audienciaId);

    }
}