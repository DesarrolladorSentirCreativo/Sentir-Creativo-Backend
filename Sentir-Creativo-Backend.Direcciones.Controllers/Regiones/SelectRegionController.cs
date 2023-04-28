using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Regiones;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Regiones.Select;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Presenters.Regiones;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Regiones;

namespace Sentir_Creativo_Backend.Direcciones.Controllers.Regiones;

public class SelectRegionController : ISelectRegionController
{
    private readonly ISelectRegionInputPort _inputPort;
    private readonly ISelectRegionPresenter _presenter;
    
    public SelectRegionController(ISelectRegionInputPort inputPort, ISelectRegionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectRegionViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectRegionViewModels;
    }
}