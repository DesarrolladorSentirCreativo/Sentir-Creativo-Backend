using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Ports.CuponesDescuentos.Select;

public interface ISelectCuponDescuentoOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectCuponDescuentoViewModel> viewModel);
}