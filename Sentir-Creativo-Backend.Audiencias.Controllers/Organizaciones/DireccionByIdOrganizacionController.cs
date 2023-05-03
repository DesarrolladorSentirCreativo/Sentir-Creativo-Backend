using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.DireccionById;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Organizaciones;

public class DireccionByIdOrganizacionController : IDireccionByIdOrganizacionController
{
    private readonly IDireccionByIdOrganizacionInputPort _inputPort;
    private readonly IDireccionByIdOrganizacionPresenter _presenter;

    public DireccionByIdOrganizacionController(
        IDireccionByIdOrganizacionInputPort inputPort,
        IDireccionByIdOrganizacionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<DireccionByIdOrganizacionViewModel> Handle(int organizacionId)
    {
        await _inputPort.Handle(organizacionId);
        return _presenter.Direccion;
    }
}