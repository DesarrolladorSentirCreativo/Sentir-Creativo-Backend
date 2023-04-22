using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Delete;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Audiencias;

public class DeleteAudienciaController : IDeleteAudienciaController
{
    private readonly IDeleteAudienciaInputPort _inputPort;
    private readonly IDeleteAudienciaPresenter _presenter;
    
    public DeleteAudienciaController(IDeleteAudienciaInputPort inputPort, IDeleteAudienciaPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(int audienciaId)
    {
        await _inputPort.Handle(audienciaId);
        return _presenter.AudienciaId;
    }
}