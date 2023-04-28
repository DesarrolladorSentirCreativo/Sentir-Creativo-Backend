using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Paises;

namespace Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Paises.Select;

public interface ISelectPaisOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectPaisViewModel> viewModel);
}