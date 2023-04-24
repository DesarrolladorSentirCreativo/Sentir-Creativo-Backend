using FluentValidation;
using Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Create;
using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;

namespace sentir_Creativo_Backend.Archivos.UseCases.Archivos.Create;

public class CreateArchivoInteractor : ICreateArchivoInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateArchivoOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateArchivoDto>> _validators;

    public CreateArchivoInteractor(IUnitOfWork unitOfWork, ICreateArchivoOutputPort outputPort,
        IEnumerable<IValidator<CreateArchivoDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _validators = validators;
    }

    public async ValueTask Handle(CreateArchivoDto dto)
    {//validamos los datos
        await Validator<CreateArchivoDto>.Validate(dto, _validators);
        
        //creamos el archivo
        var archivo = new Archivo()
        {
            Nombre = dto.Nombre,
            Path = dto.Path,
            Publico = dto.Publico,
            PublishedAt = DateTime.Now,
            Activo = true
        };
        
        //guardamos el archivo en la base de datos
        _unitOfWork.WriteRepository<Archivo>().AddEntity(archivo);
        
        //confirmamos los cambios en la base de datos
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de archivo");
        }

        await _outputPort.Handle(archivo.Id);
    }
}