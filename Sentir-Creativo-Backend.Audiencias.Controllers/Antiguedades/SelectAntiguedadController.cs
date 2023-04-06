using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Antiguedades;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Antiguedades.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Antiguedades;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Antiguedades;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Antiguedades;

public class SelectAntiguedadController : ISelectAntiguedadController
{
    private readonly ISelectAntiguedadInputPort _inputPort;
    private readonly ISelectAntiguedadPresenter _presenter;
    
    public SelectAntiguedadController(ISelectAntiguedadInputPort inputPort, ISelectAntiguedadPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }


    public async ValueTask<IReadOnlyList<SelectAntiguedadViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectAntiguedadViewModel;
    }
}