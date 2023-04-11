using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.SearchAudienciaDifusiones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Audiencias;

public class SearchAudienciasDifusionController : ISearchAudienciasDifusionController
{
    private readonly ISearchAudienciasDifusionInputPort _inputPort;
    private readonly ISearchAudienciasDifusionPresenter _presenter;
    
    public SearchAudienciasDifusionController(ISearchAudienciasDifusionInputPort inputPort,ISearchAudienciasDifusionPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;    
    }
    
    public async ValueTask<SearchAudienciasDifusionViewModel> Handle(int difusionId)
    {
        await _inputPort.Handle(difusionId);
        return _presenter.SearchAudienciasDifusionViewModel;
    }
}