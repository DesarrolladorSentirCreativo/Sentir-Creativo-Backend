using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Antiguedades.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Antiguedades;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Antiguedades;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Antiguedades.Select;

public class SelectAntiguedadInteractor : ISelectAntiguedadInputPort
{
    private readonly IReadRepository<Antiguedad, int> _readRepository;
    private readonly ISelectAntiguedadOutputPort _outputPort;
    
    public SelectAntiguedadInteractor(IReadRepository<Antiguedad, int> readRepository, ISelectAntiguedadOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new AntiguedadActivosSpecification();

        var antiguedades = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectAntiguedadViewModel> viewModels = antiguedades
            .Select(p => new SelectAntiguedadViewModel() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}