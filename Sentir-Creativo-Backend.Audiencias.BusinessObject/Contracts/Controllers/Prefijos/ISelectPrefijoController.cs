using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Prefijos;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Prefijos;

public interface ISelectPrefijoController
{
    ValueTask<IReadOnlyList<SelectPrefijoViewModel>> Handle();
}