using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Presenters;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.CuponesDescuentos.Presenters.CuponesDescuentos;

public class SelectCuponDescuentoPresenter : ISelectCuponDescuentoPresenter
{
    public IReadOnlyList<SelectCuponDescuentoViewModel> SelectCuponDescuentoViewModels { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectCuponDescuentoViewModel> viewModel)
    {
        SelectCuponDescuentoViewModels = viewModel;

        return ValueTask.CompletedTask;
    }
}