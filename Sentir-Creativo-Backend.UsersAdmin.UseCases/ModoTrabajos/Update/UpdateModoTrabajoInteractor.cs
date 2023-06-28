using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.Update;

public class UpdateModoTrabajoInteractor : IUpdateModoTrabajoInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<ModoTrabajo,int> _readRepository;
    private readonly IUpdateModoTrabajoOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateModoTrabajoDto>> _validators;
    
    public UpdateModoTrabajoInteractor(
        IUnitOfWork unitOfWork, IReadRepository<ModoTrabajo, int> readRepository,
        IUpdateModoTrabajoOutputPort outputPort, 
        IEnumerable<IValidator<UpdateModoTrabajoDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
        _validators = validators;
    }
    
    public async ValueTask Handle(UpdateModoTrabajoDto dto)
    {
        //validamos los datos
        await Validator<UpdateModoTrabajoDto>.Validate(dto, _validators);

        var spec = new ModoTrabajoActivoByIdSpecification(dto.Id);

        var modoTrabajo = await _readRepository.GetByIdWithSpec(spec);

        if (modoTrabajo == null) throw new NotFoundException("El modo de trabajo no se encuentra registrada");

        modoTrabajo.Nombre = dto.Nombre;
        modoTrabajo.Descripcion = dto.Descripcion;
        modoTrabajo.UpdatedBy = dto.UserId; 
        modoTrabajo.UpdatedAt = DateTime.Now;
        
        _unitOfWork.WriteRepository<ModoTrabajo,int>().UpdateEntity(modoTrabajo);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de modo de trabajo");
        }

        await _outputPort.Handle(modoTrabajo.Id);
    }
}