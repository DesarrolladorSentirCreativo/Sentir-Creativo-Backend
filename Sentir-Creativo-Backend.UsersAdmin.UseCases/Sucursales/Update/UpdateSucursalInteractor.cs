using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.Update;

public class UpdateSucursalInteractor : IUpdateSucursalInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Sucursal,int> _readRepository;
    private readonly IUpdateSucursalOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateSucursalDto>> _validators;

    public UpdateSucursalInteractor(
        IUnitOfWork unitOfWork,
        IUpdateSucursalOutputPort outputPort,
        IEnumerable<IValidator<UpdateSucursalDto>> validators, 
        IReadRepository<Sucursal,int> readRepository)
    {
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _validators = validators;
        _readRepository = readRepository;
    }

    public async ValueTask Handle(UpdateSucursalDto dto)
    {
        //validamos los datos
        await Validator<UpdateSucursalDto>.Validate(dto, _validators);

        var spec = new SucursalActivoByIdSpecification(dto.Id);

        var sucursal = await _readRepository.GetByIdWithSpec(spec);

        if (sucursal == null) throw new Exception("La sucursal no se encuentra registrada");
        
        sucursal.Nombre = dto.Nombre;
        sucursal.Descripcion = dto.Descripcion;
        sucursal.Direccion = dto.Direccion;
        sucursal.PaisId = dto.PaisId;
        sucursal.RegionId = dto.RegionId;
        sucursal.ComunaId = dto.ComunaId;
        sucursal.UpdatedAt = DateTime.Now;
        sucursal.UpdatedBy = dto.UserId;
        
        _unitOfWork.WriteRepository<Sucursal>().UpdateEntity(sucursal);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de sucursales");
        }

        await _outputPort.Handle(sucursal.Id);

    }
}