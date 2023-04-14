using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Update;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Audiencias;

public class UpdateAudienciaController : IUpdateAudienciaController
{
    private readonly IUpdateAudienciaInputPort _inputPort;
    private readonly IUpdateAudienciaPresenter _presenter;

    public UpdateAudienciaController(IUpdateAudienciaInputPort inputPort, IUpdateAudienciaPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<int> Handle(UpdateAudienciaDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.AudienciaId;
    }
}