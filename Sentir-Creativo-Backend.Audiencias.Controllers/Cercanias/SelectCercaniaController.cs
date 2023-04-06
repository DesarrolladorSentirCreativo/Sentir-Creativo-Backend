using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Cercanias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Cercanias.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Cercanias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Cercanias;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Cercanias;

public class SelectCercaniaController : ISelectCercaniaController
{
    private readonly ISelectCercaniaInputPort _inputPort;
    private readonly ISelectCercaniaPresenter _presenter;
    
    public SelectCercaniaController(ISelectCercaniaInputPort inputPort, ISelectCercaniaPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<IReadOnlyList<SelectCercaniaViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectCercaniaViewModel;
    }
}