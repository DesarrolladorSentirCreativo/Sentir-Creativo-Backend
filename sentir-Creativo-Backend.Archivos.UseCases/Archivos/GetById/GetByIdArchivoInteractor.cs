using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.GetById;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Specifications.Archivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;
using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace sentir_Creativo_Backend.Archivos.UseCases.Archivos.GetById;

public class GetByIdArchivoInteractor : IGetByIdArchivoInputPort
{
    private readonly IReadRepository<Archivo,int> _readRepository;
    private readonly IGetByIdArchivoOutputPort _outputPort;
    
    public GetByIdArchivoInteractor(
        IReadRepository<Archivo,int> readRepository, 
        IGetByIdArchivoOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int archivoId)
    {
        var spec = new ArchivoSpecification(archivoId);
        
        var archivo = await _readRepository.GetByIdWithSpec(spec);
        
        //validamos si existe el archivo
        if(archivo == null) throw new Exception("No se encontró ningún archivo.");


        var modelView = new GetByIdArchivoViewModel()
        {
            Id = archivo.Id,
            Nombre = archivo.Nombre,
            TipoArchivoId = archivo.TipoArchivoId,
            Path = archivo.Path,
            TipoArchivo = archivo.TipoArchivo?.Nombre,
            Publico = archivo.Publico,
            PublishedAt = archivo.PublishedAt,
        };
        
        await _outputPort.Handle(modelView);
    }
}