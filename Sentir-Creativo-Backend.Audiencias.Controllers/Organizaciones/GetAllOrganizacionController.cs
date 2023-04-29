using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.GetAll;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Organizaciones;

public class GetAllOrganizacionController : IGetAllOrganizacionController
{
    private readonly IGetAllOrganizacionInputPort _inputPort;
    private readonly IGetAllOrganizacionPresenter _presenter;
    
    public GetAllOrganizacionController(IGetAllOrganizacionInputPort inputPort, IGetAllOrganizacionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<GetAllOrganizacionViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.GetAllOrganizaciones;
    }
}