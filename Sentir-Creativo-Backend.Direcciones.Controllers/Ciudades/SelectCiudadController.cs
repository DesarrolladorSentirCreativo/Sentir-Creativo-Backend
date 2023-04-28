using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Ciudades;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Ciudades.Select;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Presenters.Ciudades;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Ciudades;

namespace Sentir_Creativo_Backend.Direcciones.Controllers.Ciudades;

public class SelectCiudadController : ISelectCiudadController
{
    private readonly ISelectCiudadInputPort _inputPort;
    private readonly ISelectCiudadPresenter _presenter;
    
    public SelectCiudadController(ISelectCiudadInputPort inputPort, ISelectCiudadPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectCiudadViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectCiudadViewModels;
    }
}