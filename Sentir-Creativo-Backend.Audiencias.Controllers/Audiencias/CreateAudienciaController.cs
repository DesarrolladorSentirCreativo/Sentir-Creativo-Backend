using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Create;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Audiencias;

public class CreateAudienciaController : ICreateAudienciaController
{
    private readonly ICreateAudienciaInputPort _inputPort;
    private readonly ICreateAudienciaPresenter _presenter;
    
    public CreateAudienciaController(ICreateAudienciaInputPort inputPort, ICreateAudienciaPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreateAudienciaDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.Id;
    }
}