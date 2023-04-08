using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Antiguedades;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Antiguedades;

public interface ISelectAntiguedadController
{
    ValueTask<IReadOnlyList<SelectAntiguedadViewModel>> Handle();
}