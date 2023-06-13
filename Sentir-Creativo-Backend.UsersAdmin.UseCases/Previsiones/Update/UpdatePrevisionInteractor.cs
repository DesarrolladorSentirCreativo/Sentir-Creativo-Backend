using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.Update;

public class UpdatePrevisionInteractor : IUpdatePrevisionInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Prevision,int> _readRepository;
    private readonly IUpdatePrevisionOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdatePrevisionDto>> _validators;
    
    public UpdatePrevisionInteractor(
        IUnitOfWork unitOfWork, IReadRepository<Prevision, int> readRepository,
        IUpdatePrevisionOutputPort outputPort, 
        IEnumerable<IValidator<UpdatePrevisionDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
        _validators = validators;
    }
    
    public async ValueTask Handle(UpdatePrevisionDto dto)
    {
        //validamos los datos
        await Validator<UpdatePrevisionDto>.Validate(dto, _validators);

        var spec = new PrevisionActivoByIdSpecification(dto.Id);

        var prevision = await _readRepository.GetByIdWithSpec(spec);

        if (prevision == null) throw new Exception("El prevision no se encuentra registrado");

        prevision.Nombre = dto.Nombre;
        prevision.Descripcion = dto.Descripcion;
        prevision.UpdatedBy = dto.UserId; 
        prevision.UpdatedAt = DateTime.Now;
        
        _unitOfWork.WriteRepository<Prevision,int>().UpdateEntity(prevision);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de prevision");
        }

        await _outputPort.Handle(prevision.Id);
    }
}