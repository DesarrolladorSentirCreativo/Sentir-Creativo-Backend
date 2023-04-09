using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetById;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Audiencias;

public class GetByIdAudienciaController : IGetByIdAudienciaController
{
    private readonly IGetByIdAudienciaInputPort _inputPort;
    private readonly IGetByIdAudienciaPresenter _presenter;

    public GetByIdAudienciaController(IGetByIdAudienciaInputPort inputPort, IGetByIdAudienciaPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<GetByIdAudienciaViewModel> Handle(int audienciaId)
    {
        await _inputPort.Handle(audienciaId);
        return _presenter.GetByIdAudenciaViewModel;
    }
}