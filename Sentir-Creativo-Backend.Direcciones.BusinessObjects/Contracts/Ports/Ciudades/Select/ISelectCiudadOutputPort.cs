using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Ciudades;

namespace Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Ciudades.Select;

public interface ISelectCiudadOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectCiudadViewModel> modelViews);
}