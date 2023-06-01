using FluentValidation;
using Senitr_Creativo_Backend.Comentarios.Entities.POCOEntities;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.DTO;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Update;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;

namespace Sentir_Creativo_Backend.Comentarios.UseCases.Update;

public class UpdateComentarioInteractor : IUpdateComentarioInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Comentario,int> _readRepository;
    private readonly IUpdateComentarioOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateComentarioDto>> _validators;
    
    public UpdateComentarioInteractor(
        IUnitOfWork unitOfWork,
        IReadRepository<Comentario,int> readRepository,
        IUpdateComentarioOutputPort outputPort, 
        IEnumerable<IValidator<UpdateComentarioDto>> validators)
    {
        _outputPort = outputPort;
        _readRepository = readRepository;
        _validators = validators;
        _unitOfWork = unitOfWork;
    }
    
    public async ValueTask Handle(UpdateComentarioDto dto)
    {
        //validamos los datos
        await Validator<UpdateComentarioDto>.Validate(dto, _validators);

        var comentario = await _readRepository.GetByIdAsync(dto.Id);

        if (comentario == null) throw new Exception("El comentario no se encuentra registrada");
        
        comentario.Descripcion = dto.Descripcion;
        comentario.PublishedAt = DateTime.Now;
        comentario.UpdatedAt = DateTime.Now;
        comentario.CreatedBy = dto.UserId;
        comentario.UpdatedBy = dto.UserId;
        
        _unitOfWork.WriteRepository<Comentario,int>().UpdateEntity(comentario);

        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de comentarios");
        }
        
        await _outputPort.Handle(comentario.Id);
    }
}