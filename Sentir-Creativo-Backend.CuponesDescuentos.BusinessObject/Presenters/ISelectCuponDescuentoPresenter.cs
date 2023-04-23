using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Ports.CuponesDescuentos.Select;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Presenters;

public interface ISelectCuponDescuentoPresenter : ISelectCuponDescuentoOutputPort
{
    public IReadOnlyList<SelectCuponDescuentoViewModel> SelectCuponDescuentoViewModels { get; }
}