using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Create;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Organizaciones;

public class CreateOrganizacionController : ICreateOrganizacionController
{
    private readonly ICreateOrganizacionInputPort _inputPort;
    private readonly ICreateOrganizacionPresenter _presenter;
    
    public CreateOrganizacionController(
        ICreateOrganizacionInputPort inputPort, 
        ICreateOrganizacionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreateOrganizacionDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.OrganizacionId;
    }
}