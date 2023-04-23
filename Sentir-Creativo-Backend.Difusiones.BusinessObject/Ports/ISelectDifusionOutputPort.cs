using Sentir_Creativo_Backend.Difusiones.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Difusiones.BusinessObject.Ports;

public interface ISelectDifusionOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectDifusionViewModel> viewModel);
}