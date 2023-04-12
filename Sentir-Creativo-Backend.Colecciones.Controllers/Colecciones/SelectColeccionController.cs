using Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Controllers.Colecciones;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Ports.Colecciones.Select;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Presenters.Colecciones;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.ViewModels.Colecciones;

namespace Sentir_Creativo_Backend.Colecciones.Controllers.Colecciones;

public class SelectColeccionController : ISelectColeccionController
{
    private readonly ISelectColeccionInputPort _inputPort;
    private readonly ISelectColeccionPresenter _presenter;
    
    public SelectColeccionController(ISelectColeccionInputPort inputPort, ISelectColeccionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectColeccionViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectColeccionViewModel;
    }
}