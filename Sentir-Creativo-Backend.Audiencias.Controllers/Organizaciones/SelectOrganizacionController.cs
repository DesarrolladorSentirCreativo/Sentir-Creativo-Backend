using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Organizaciones;

public class SelectOrganizacionController : ISelectOrganizacionController
{
    private readonly ISelectOrganizacionInputPort _inputPort;
    private readonly ISelectOrganizacionPresenter _presenter;
    
    public SelectOrganizacionController(ISelectOrganizacionInputPort inputPort, ISelectOrganizacionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectOrganizacionViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectOrganizacionViewModel;
    }
}