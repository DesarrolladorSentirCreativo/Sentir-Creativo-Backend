using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Regiones.Select;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Regiones;

namespace Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Presenters.Regiones;

public interface ISelectRegionPresenter : ISelectRegionOutputPort
{
    IReadOnlyList<SelectRegionViewModel> SelectRegionViewModels { get; }
}