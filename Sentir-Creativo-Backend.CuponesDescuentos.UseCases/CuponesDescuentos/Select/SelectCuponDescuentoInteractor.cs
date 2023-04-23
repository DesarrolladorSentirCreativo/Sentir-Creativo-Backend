using Sentir_Creativo_Backend.CuponDescuentos.Entities.POCOEntities;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Ports.CuponesDescuentos.Select;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Specifications;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.ViewModels;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.CuponesDescuentos.UseCases.CuponesDescuentos.Select;

public class SelectCuponDescuentoInteractor : ISelectCuponDescuentoInputPort
{
    private readonly IReadRepository<CuponDescuento, int> _readRepository;
    private readonly ISelectCuponDescuentoOutputPort _outputPort;
    
    public SelectCuponDescuentoInteractor(IReadRepository<CuponDescuento, int> readRepository, ISelectCuponDescuentoOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new CuponDescuentoActivosSpecification();

        var cuponesDescuentos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectCuponDescuentoViewModel> viewModels = cuponesDescuentos
            .Select(p => new SelectCuponDescuentoViewModel() { Id = p.Id, Codigo = p.Codigo})
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(viewModels);
    }
}