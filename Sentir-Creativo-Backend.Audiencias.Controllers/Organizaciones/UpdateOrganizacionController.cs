using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Update;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Organizaciones;

public class UpdateOrganizacionController : IUpdateOrganizacionController
{
    private readonly IUpdateOrganizacionInputPort _inputPort;
    private readonly IUpdateOrganizacionPresenter _presenter;

    public UpdateOrganizacionController(IUpdateOrganizacionInputPort inputPort, 
        IUpdateOrganizacionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(UpdateOrganizacionDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.OrganizacionId;
    }
}