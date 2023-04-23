using Sentir_Creativo_Backend.Difusiones.BusinessObject.Controllers;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.Ports;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.Presenters;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Difusiones.Controllers.Difusiones;

public class SelectDifusionController : ISelectDifusionController
{
    private readonly ISelectDifusionInputPort _inputPort;
    private readonly ISelectDifusionPresenter _presenter;
    
    public SelectDifusionController(ISelectDifusionInputPort inputPort, ISelectDifusionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectDifusionViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectDifusionViewModels;
    }
}