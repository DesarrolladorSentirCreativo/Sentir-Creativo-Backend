using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.Create;

public class CreateModoTrabajoInteractor : ICreateModoTrabajoInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateModoTrabajoOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateModoTrabajoDto>> _validators;
    
    public CreateModoTrabajoInteractor(IUnitOfWork unitOfWork, 
        ICreateModoTrabajoOutputPort outputPort,
        IEnumerable<IValidator<CreateModoTrabajoDto>> validators)
    {
        _outputPort = outputPort;
        _unitOfWork = unitOfWork;
        _validators = validators;
    }
    
    public async ValueTask Handle(CreateModoTrabajoDto dto)
    {
        //validamos los datos
        await Validator<CreateModoTrabajoDto>.Validate(dto, _validators);
        
        var afp = new ModoTrabajo()
        {
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            Activo = true
        };
        
        _unitOfWork.WriteRepository<ModoTrabajo,int>().AddEntity(afp);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de modo de trabajo");
        }
        
        await _outputPort.Handle(afp.Id);
    }
}