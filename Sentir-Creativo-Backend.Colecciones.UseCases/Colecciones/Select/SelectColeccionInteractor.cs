using Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Ports.Colecciones.Select;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.Specifications.Colecciones;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.ViewModels.Colecciones;
using Sentir_Creativo_Backend.Colecciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Colecciones.UseCases.Colecciones.Select;

public class SelectColeccionInteractor : ISelectColeccionInputPort
{
    private readonly IReadRepository<Coleccion, int> _readRepository;
    private readonly ISelectColeccionOutputPort _outputPort;
    
    public SelectColeccionInteractor(IReadRepository<Coleccion, int> readRepository, ISelectColeccionOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new ColeccionActivosSpecification();

        var colecciones = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectColeccionViewModel> viewModels = colecciones
            .Select(p => new SelectColeccionViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}