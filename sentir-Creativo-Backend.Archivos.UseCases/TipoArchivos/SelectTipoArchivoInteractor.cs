using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.TipoArchivo.Select;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Specifications.TipoArchivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;
using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace sentir_Creativo_Backend.Archivos.UseCases.TipoArchivos;

public class SelectTipoArchivoInteractor : ISelectTipoArchivoInputPort
{
    private readonly IReadRepository<TipoArchivo,int> _readRepository;
    private readonly ISelectTipoArchivoOutputPort _outputPort;
    
    public SelectTipoArchivoInteractor(
        IReadRepository<TipoArchivo,int> readRepository, 
        ISelectTipoArchivoOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new TipoArchivoActivosSpecification();

        var tipoArchivos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectTipoArchivoViewModel> viewModels = tipoArchivos
            .Select(p => new SelectTipoArchivoViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
        
    }
}