using FluentValidation;
using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.DTO;
using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Ports.Bitacoras.Create;
using Sentir_Creativo_Backend.Bitacoras.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;

namespace Sentir_Creativo_Backend.Bitacoras.UseCases.Bitacoras.Create;

public class CreateBitacoraInteractor : ICreateBitacoraInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateBitacoraOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateBitacoraDto>> _validators;

    public CreateBitacoraInteractor(
        IUnitOfWork unitOfWork,
        ICreateBitacoraOutputPort outputPort,
        IEnumerable<IValidator<CreateBitacoraDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _validators = validators;
    }

    public async ValueTask Handle(CreateBitacoraDto dto)
    {
        //validamos los datos
        await Validator<CreateBitacoraDto>.Validate(dto, _validators);
        
        //creamos el archivo
        var bitacora = new Bitacora()
        {
            Entidad = dto.Entidad,
            Accion = dto.Accion,
            Contenido = dto.Contenido,
            Via = dto.Via,
            Autor = dto.Autor,
            Fecha = dto.Fecha,
            PublishedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            Activo = true
        };
        
        //guardamos la bitacora en la base de datos
        _unitOfWork.WriteRepository<Bitacora>().AddEntity(bitacora);
        
        //confirmamos los cambios en la base de datos
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de bitacora");
        }

        await _outputPort.Handle(bitacora.Id);
    }
}