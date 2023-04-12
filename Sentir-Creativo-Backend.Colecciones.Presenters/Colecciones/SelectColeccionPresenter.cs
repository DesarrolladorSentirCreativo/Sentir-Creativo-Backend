using Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Presenters.Colecciones;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.ViewModels.Colecciones;

namespace Sentir_Creativo_Backend.Colecciones.Presenters.Colecciones;

public class SelectColeccionPresenter : ISelectColeccionPresenter
{
    public IReadOnlyList<SelectColeccionViewModel> SelectColeccionViewModel { get; private set; }

    public ValueTask Handle(IReadOnlyList<SelectColeccionViewModel> modelView)
    {
        SelectColeccionViewModel = modelView;

        return ValueTask.CompletedTask;
    }
}