using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Rubros;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Rubros;

public interface ISelectRubroController
{
    ValueTask<IReadOnlyList<SelectRubroViewModel>> Handle();
}