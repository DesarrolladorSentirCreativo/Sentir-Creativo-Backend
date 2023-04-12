using Sentir_Creativo_Backend.Colecciones.BusinessObject.ViewModels.Colecciones;

namespace Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Ports.Colecciones.Select;

public interface ISelectColeccionOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectColeccionViewModel> modelView);
}