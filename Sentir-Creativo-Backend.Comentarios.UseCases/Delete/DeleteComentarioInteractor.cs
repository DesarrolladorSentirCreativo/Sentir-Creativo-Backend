using Senitr_Creativo_Backend.Comentarios.Entities.POCOEntities;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Delete;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;

namespace Sentir_Creativo_Backend.Comentarios.UseCases.Delete;

public class DeleteComentarioInteractor : IDeleteComentarioInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Comentario,int> _readRepository;
    private readonly IDeleteComentarioOutputPort _outputPort;

    public DeleteComentarioInteractor(
        IUnitOfWork unitOfWork, 
        IReadRepository<Comentario, int> readRepository,
        IDeleteComentarioOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle(int comentarioId)
    {
        var comentario = await _readRepository.GetByIdAsync(comentarioId);

        if (comentario == null) throw new NotFoundException("El comentario no se encuentra registrado");
        
        _unitOfWork.WriteRepository<Comentario,int>().DeleteEntity(comentario);

        await _unitOfWork.Complete();

        await _outputPort.Handle(comentarioId);

    }
}