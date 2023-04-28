using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Presenters.Ciudades;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Ciudades;

namespace Sentir_Creativo_Backend.Direcciones.Presenters.Ciudades;

public class SelectCiudadPresenter : ISelectCiudadPresenter
{
    public IReadOnlyList<SelectCiudadViewModel> SelectCiudadViewModels { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectCiudadViewModel> modelViews)
    {
        SelectCiudadViewModels = modelViews;

        return ValueTask.CompletedTask;
    }
}