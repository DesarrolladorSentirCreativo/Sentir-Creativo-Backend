using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetAll;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Audiencias;

public class GetAllAudienciaController : IGetAllAudienciaController
{
    private readonly IGetAllAudienciaInputPort _inputPort;
    private readonly IGetAllAudienciaPresenter _presenter;

    public GetAllAudienciaController(IGetAllAudienciaInputPort inputPort, IGetAllAudienciaPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<IReadOnlyList<GetAllAudienciaViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.List;
    }
}