using Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Ports.Colecciones.Select;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.ViewModels.Colecciones;

namespace Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Presenters.Colecciones;

public interface ISelectColeccionPresenter : ISelectColeccionOutputPort
{
    IReadOnlyList<SelectColeccionViewModel> SelectColeccionViewModel { get; }
}