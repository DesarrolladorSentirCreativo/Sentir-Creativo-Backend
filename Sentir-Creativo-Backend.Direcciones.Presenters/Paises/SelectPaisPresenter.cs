using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Presenters.Paises;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Paises;

namespace Sentir_Creativo_Backend.Direcciones.Presenters.Paises;

public class SelectPaisPresenter : ISelectPaisPresenter
{
    public IReadOnlyList<SelectPaisViewModel> SelectPaisViewModels { get; private set; }
    public ValueTask Handle(IReadOnlyList<SelectPaisViewModel> viewModel)
    {
        SelectPaisViewModels = viewModel;

        return ValueTask.CompletedTask;
    }
    
}