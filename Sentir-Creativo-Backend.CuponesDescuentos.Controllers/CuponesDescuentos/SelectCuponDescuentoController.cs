using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Controllers;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Ports.CuponesDescuentos.Select;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Presenters;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.CuponesDescuentos.Controllers.CuponesDescuentos;

public class SelectCuponDescuentoController : ISelectCuponDescuentoController
{
    private readonly ISelectCuponDescuentoInputPort _inputPort;
    private readonly ISelectCuponDescuentoPresenter _presenter;

    public SelectCuponDescuentoController(
        ISelectCuponDescuentoInputPort inputPort,
        ISelectCuponDescuentoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<IReadOnlyList<SelectCuponDescuentoViewModel>> Handle()
    {
        await _inputPort.Handle();
        
        return _presenter.SelectCuponDescuentoViewModels;
    }
}