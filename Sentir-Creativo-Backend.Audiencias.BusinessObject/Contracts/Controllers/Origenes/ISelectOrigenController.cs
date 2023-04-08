using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Origenes;

public interface ISelectOrigenController
{
    ValueTask<IReadOnlyList<SelectOrigenViewModel>> Handle();
}