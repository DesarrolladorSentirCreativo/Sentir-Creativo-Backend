using Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Presenters.Areas;
using Sentir_Creativo_Backend.Areas.BusinessObject.ViewModels.Areas;

namespace Sentir_Creativo_Backend.Areas.Presenters.Areas;

public class SelectAreaPresenter : ISelectAreaPresenter
{
    public IReadOnlyList<SelectAreaViewModel> SelectAreaViewModel { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectAreaViewModel> modelView)
    {
        SelectAreaViewModel = modelView;

        return ValueTask.CompletedTask;
    }
    
}