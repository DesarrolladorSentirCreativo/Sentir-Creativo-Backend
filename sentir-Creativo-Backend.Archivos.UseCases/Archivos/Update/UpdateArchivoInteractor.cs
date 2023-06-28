using FluentValidation;
using Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Update;
using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;

namespace sentir_Creativo_Backend.Archivos.UseCases.Archivos.Update;

public class UpdateArchivoInteractor : IUpdateArchivoInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUpdateArchivoOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateArchivoDto>> _validators;
    private readonly IReadRepository<Archivo,int> _readRepository;

    public UpdateArchivoInteractor(
        IUnitOfWork unitOfWork,
        IUpdateArchivoOutputPort outputPort,
        IEnumerable<IValidator<UpdateArchivoDto>> validators,
        IReadRepository<Archivo,int> readRepository)
    {
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _validators = validators;
        _readRepository = readRepository;
    }

    public async ValueTask Handle(UpdateArchivoDto dto)
    {
        //validamos los datos
        await Validator<UpdateArchivoDto>.Validate(dto, _validators);
        
        var archivo = await _readRepository.GetByIdAsync(dto.Id);
        
        if(archivo == null) throw new NotFoundException($"No existe el archivo con id {dto.Id}");

        archivo.Nombre = dto.Nombre;
        archivo.TipoArchivoId = dto.TipoArchivoId;  
        archivo.Nombre = dto.Nombre;
        archivo.Path = dto.Path;
        archivo.Publico = dto.Publico;
        archivo.UpdatedBy = dto.UserId;
        archivo.PublishedAt = DateTime.Now;
        archivo.UpdatedAt = DateTime.Now;
        
        //actualizamos los datos
        _unitOfWork.WriteRepository<Archivo,int>().UpdateEntity(archivo);

        await _unitOfWork.Complete();

        await _outputPort.Handle(archivo.Id);

    }
}