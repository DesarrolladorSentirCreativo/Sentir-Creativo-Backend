using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AFP;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.AFP.Create;

public class CreateAfpInteractor : ICreateAfpInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateAfpOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateAfpDto>> _validators;
    
    public CreateAfpInteractor(IUnitOfWork unitOfWork, 
        ICreateAfpOutputPort outputPort,
        IEnumerable<IValidator<CreateAfpDto>> validators)
    {
        _outputPort = outputPort;
        _unitOfWork = unitOfWork;
        _validators = validators;
    }
    
    public async ValueTask Handle(CreateAfpDto dto)
    {
        //validamos los datos
        await Validator<CreateAfpDto>.Validate(dto, _validators);
        
        var afp = new Afp()
        {
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            Activo = true
        };
        
        _unitOfWork.WriteRepository<Afp,int>().AddEntity(afp);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de afp");
        }
        
        await _outputPort.Handle(afp.Id);
    }
}