using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Rubros;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Rubros.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Rubros;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Rubros;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Rubros;

public class SelectRubroController : ISelectRubroController
{
    private readonly ISelectRubroInputPort _inputPort;
    private readonly ISelectRubroPresenter _presenter;
    
    public SelectRubroController(ISelectRubroInputPort inputPort, ISelectRubroPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectRubroViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectRubros;
    }
}