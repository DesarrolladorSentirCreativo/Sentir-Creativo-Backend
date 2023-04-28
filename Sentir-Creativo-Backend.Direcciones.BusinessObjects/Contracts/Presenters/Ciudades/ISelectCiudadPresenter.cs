using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Ciudades.Select;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Ciudades;

namespace Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Presenters.Ciudades;

public interface ISelectCiudadPresenter : ISelectCiudadOutputPort
{
    IReadOnlyList<SelectCiudadViewModel> SelectCiudadViewModels { get; }
}