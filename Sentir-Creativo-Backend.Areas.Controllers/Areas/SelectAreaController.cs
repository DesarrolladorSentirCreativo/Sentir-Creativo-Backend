using Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Controllers.Areas;
using Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Ports.Areas.Select;
using Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Presenters.Areas;
using Sentir_Creativo_Backend.Areas.BusinessObject.ViewModels.Areas;

namespace Sentir_Creativo_Backend.Areas.Controllers.Areas;

public class SelectAreaController : ISelectAreaController
{
    private readonly ISelectAreaInputPort _inputPort;
    private readonly ISelectAreaPresenter _presenter;
    
    public SelectAreaController(ISelectAreaInputPort inputPort, ISelectAreaPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectAreaViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectAreaViewModel;
    }
}