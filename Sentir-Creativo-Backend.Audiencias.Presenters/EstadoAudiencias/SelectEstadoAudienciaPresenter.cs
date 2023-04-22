using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.EstadoAudiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.EstadoAudiencias;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.EstadoAudiencias;

public class SelectEstadoAudienciaPresenter : ISelectEstadoAudienciaPresenter
{
    public IReadOnlyList<SelectEstadoAudienciaViewModel> SelectEstadoAudienciaViewModel { get; private set; }
    public ValueTask Handle(IReadOnlyList<SelectEstadoAudienciaViewModel> modelView)
    {
        SelectEstadoAudienciaViewModel = modelView;

        return ValueTask.CompletedTask;
    }

  
}