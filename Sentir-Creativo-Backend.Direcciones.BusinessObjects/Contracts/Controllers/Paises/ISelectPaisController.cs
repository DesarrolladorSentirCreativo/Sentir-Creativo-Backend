using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Paises;

namespace Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Paises;

public interface ISelectPaisController
{
    ValueTask<IReadOnlyList<SelectPaisViewModel>> Handle();
}