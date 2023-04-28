using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Presenters.Regiones;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Regiones;

namespace Sentir_Creativo_Backend.Direcciones.Presenters.Regiones;

public class SelectRegionPresenter : ISelectRegionPresenter
{
    public IReadOnlyList<SelectRegionViewModel> SelectRegionViewModels { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectRegionViewModel> viewModels)
    {
        SelectRegionViewModels = viewModels;

        return ValueTask.CompletedTask;
    }
}