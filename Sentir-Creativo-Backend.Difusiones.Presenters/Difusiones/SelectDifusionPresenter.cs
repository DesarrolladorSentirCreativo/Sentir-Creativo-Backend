using Sentir_Creativo_Backend.Difusiones.BusinessObject.Presenters;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Difusiones.Presenters.Difusiones;

public class SelectDifusionPresenter : ISelectDifusionPresenter
{
    public IReadOnlyList<SelectDifusionViewModel> SelectDifusionViewModels { get; private set; }
    public ValueTask Handle(IReadOnlyList<SelectDifusionViewModel> viewModel)
    {
        SelectDifusionViewModels = viewModel;
        
        return ValueTask.CompletedTask;
    }
}