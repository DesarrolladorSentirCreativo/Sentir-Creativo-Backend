using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Paises;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Paises.Select;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Presenters.Paises;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Paises;

namespace Sentir_Creativo_Backend.Direcciones.Controllers.Paises;

public class SelectPaisController : ISelectPaisController
{
    private readonly ISelectPaisInputPort _inputPort;
    private readonly ISelectPaisPresenter _presenter;
    
    public SelectPaisController(ISelectPaisInputPort inputPort, ISelectPaisPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectPaisViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectPaisViewModels;
    }
}