using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.Formatos;

namespace Sentir_Creativo_Backend.Servicios.Controllers.Formatos;

public class SelectFormatoController : ISelectFormatoController
{
    private readonly ISelectFormatoInputPort _inputPort;
    private readonly ISelectFormatoPresenter _presenter;
    
    public SelectFormatoController(ISelectFormatoInputPort inputPort, ISelectFormatoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<IReadOnlyList<SelectFormatoViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectFormatoViewModel;
    }
}