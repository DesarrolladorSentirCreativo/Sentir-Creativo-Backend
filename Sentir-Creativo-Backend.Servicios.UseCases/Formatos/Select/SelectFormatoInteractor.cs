using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.Formatos;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.Formatos;
using Sentir_Creativo_Backend.Servicios.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Servicios.UseCases.Formatos.Select;

public class SelectFormatoInteractor : ISelectFormatoInputPort
{
    private readonly IReadRepository<Formato, int> _readRepository;
    private readonly ISelectFormatoOutputPort _outputPort;
    
    public SelectFormatoInteractor(IReadRepository<Formato, int> readRepository, ISelectFormatoOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new FormatoActivosSpecification();

        var formatos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectFormatoViewModel> viewModels = formatos
            .Select(p => new SelectFormatoViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}