using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Cercanias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Cercanias;

public interface ISelectCercaniaController
{
    ValueTask<IReadOnlyList<SelectCercaniaViewModel>> Handle();
}