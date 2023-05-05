using FluentValidation;
using Senitr_Creativo_Backend.Comentarios.Entities.DTO;
using Senitr_Creativo_Backend.Comentarios.Entities.POCOEntities;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Create;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;

namespace Sentir_Creativo_Backend.Comentarios.UseCases.Create;

public class CreateComentarioInteractor : ICreateComentarioInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateComentarioOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateComentarioDto>> _validators;

    public CreateComentarioInteractor(
        IUnitOfWork unitOfWork,
        ICreateComentarioOutputPort outputPort,
        IEnumerable<IValidator<CreateComentarioDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _validators = validators;
    }

    public async ValueTask Handle(CreateComentarioDto dto)
    {
        //validamos los datos
        await Validator<CreateComentarioDto>.Validate(dto, _validators);
        
        //creamos el comentario
        var comentario = new Comentario()
        {
            Descripcion = dto.Descripcion,
            CreatedBy = dto.UserId,
            CreatedAt = DateTime.Now,
            PublishedAt = DateTime.Now
        };
        
        _unitOfWork.WriteRepository<Comentario>().AddEntity(comentario);

        var result  = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de comentarios");
        }
        
        await _outputPort.Handle(comentario.Id);
    }
}