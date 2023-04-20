using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Presenters.Audiencias;

public class GetAllAudienciaPresenter : IGetAllAudienciaPresenter
{
    public IReadOnlyList<GetAllAudienciaViewModel> List { get; private set; }

    public ValueTask Handle(IReadOnlyList<GetAllAudienciaViewModel> viewModel)
    {
        List = viewModel;
        
        return ValueTask.CompletedTask;
    }
}