using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.Create;

public class CreateModuloInteractor : ICreateModuloInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateModuloOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateModuloDto>> _validators;

    public CreateModuloInteractor(IUnitOfWork unitOfWork, 
        ICreateModuloOutputPort outputPort,
        IEnumerable<IValidator<CreateModuloDto>> validators)
    {
        _outputPort = outputPort;
        _unitOfWork = unitOfWork;
        _validators = validators;
    }
    
    public async ValueTask Handle(CreateModuloDto dto)
    {
        //validamos los datos
        await Validator<CreateModuloDto>.Validate(dto, _validators);
        
        var modulo = new Modulo()
        {
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            Activo = true
        };
        
        _unitOfWork.WriteRepository<Modulo,int>().AddEntity(modulo);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de modulos");
        }
        
        await _outputPort.Handle(modulo.Id);
    }
}