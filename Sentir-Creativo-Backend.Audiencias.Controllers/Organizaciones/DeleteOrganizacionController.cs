using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Delete;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Organizaciones;

public class DeleteOrganizacionController : IDeleteOrganizacionController
{
    private readonly IDeleteOrganizacionInputPort _inputPort;
    private readonly IDeleteOrganizacionPresenter _presenter;
    
    public DeleteOrganizacionController(
        IDeleteOrganizacionInputPort inputPort,
        IDeleteOrganizacionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(int organizacionId)
    {
        await _inputPort.Handle(organizacionId);
        return _presenter.OrganizacionId;
    }
}