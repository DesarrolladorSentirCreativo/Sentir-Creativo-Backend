using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.Create;

public class CreateSucursalInteractor : ICreateSucursalInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateSucursalOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateSucursalDto>> _validators;
    
    public CreateSucursalInteractor(
        IUnitOfWork unitOfWork, 
        ICreateSucursalOutputPort outputPort,
        IEnumerable<IValidator<CreateSucursalDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _validators = validators;
    }
    
    public async ValueTask Handle(CreateSucursalDto dto)
    {
        //validamos los datos
        await Validator<CreateSucursalDto>.Validate(dto, _validators);

        var sucursal = new Sucursal()
        {
            Nombre = dto.Nombre,
            Direccion = dto.Direccion,
            Descripcion = dto.Descripcion,
            PaisId = dto.PaisId,
            RegionId = dto.RegionId,
            ComunaId = dto.CiudadId,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            Activo = true
        };
        
        _unitOfWork.WriteRepository<Sucursal,int>().AddEntity(sucursal);
        
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de sucursales");
        }
        
        await _outputPort.Handle(sucursal.Id);
        
    }
}