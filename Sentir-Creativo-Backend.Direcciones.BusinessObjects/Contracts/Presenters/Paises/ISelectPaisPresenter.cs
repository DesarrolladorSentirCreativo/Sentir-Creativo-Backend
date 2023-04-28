using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Paises.Select;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Paises;

namespace Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Presenters.Paises;

public interface ISelectPaisPresenter : ISelectPaisOutputPort
{
    IReadOnlyList<SelectPaisViewModel> SelectPaisViewModels { get; }
}