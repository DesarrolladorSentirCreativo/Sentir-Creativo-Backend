using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.Update;

public class UpdateModuloInteractor : IUpdateModuloInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Modulo,int> _readRepository;
    private readonly IUpdateModuloOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateModuloDto>> _validators;

    public UpdateModuloInteractor(
        IUnitOfWork unitOfWork,
        IReadRepository<Modulo, int> readRepository,
        IUpdateModuloOutputPort outputPort,
        IEnumerable<IValidator<UpdateModuloDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
        _validators = validators;
    }


    public async ValueTask Handle(UpdateModuloDto dto)
    {
        //validamos los datos
        await Validator<UpdateModuloDto>.Validate(dto, _validators);

        var spec = new ModuloActivoByIdSpecification(dto.Id);

        var modulo = await _readRepository.GetByIdWithSpec(spec);

        if (modulo == null) throw new Exception("El modulo no se encuentra registrada");

        modulo.Nombre = dto.Nombre;
        modulo.Descripcion = dto.Descripcion;
        modulo.UpdatedBy = dto.UserId;
        modulo.UpdatedAt = DateTime.Now;
        
        _unitOfWork.WriteRepository<Modulo>().UpdateEntity(modulo);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de modulos");
        }

        await _outputPort.Handle(modulo.Id);
    }
}