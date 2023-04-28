using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Regiones;

namespace Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Ports.Regiones.Select;

public interface ISelectRegionOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectRegionViewModel> viewModels);
}