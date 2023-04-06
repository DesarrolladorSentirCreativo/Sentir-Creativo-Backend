using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Motivaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Motivaciones;

public interface ISelectMotivacionController
{
    ValueTask<IReadOnlyList<SelectMotivacionViewModel>> Handle();
}