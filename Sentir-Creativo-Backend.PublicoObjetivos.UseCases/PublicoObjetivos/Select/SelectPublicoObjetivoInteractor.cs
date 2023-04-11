using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.Select;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Specifications.PublicoObjetivos;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.ViewModels;
using Sentir_Creativo_Backend.PublicoObjetivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.PublicoObjetivos.UseCases.PublicoObjetivos.Select;

public class SelectPublicoObjetivoInteractor : ISelectPublicoObjetivoInputPort
{
    private readonly IReadRepository<PublicoObjetivo, int> _readRepository;
    private readonly ISelectPublicoObjetivoOutputPort _outputPort;
    
    public SelectPublicoObjetivoInteractor(IReadRepository<PublicoObjetivo, int> readRepository, ISelectPublicoObjetivoOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    
    public async ValueTask Handle()
    {
        var spec = new PublicoObjetivosActivosSpecification();

        var publicoObjetivos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectPublicoObjetivoViewModel> viewModels = publicoObjetivos
            .Select(p => new SelectPublicoObjetivoViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}