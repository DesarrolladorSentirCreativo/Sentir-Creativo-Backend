using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Motivaciones.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Motivaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Motivaciones;

public interface ISelectMotivacionPresenter: ISelectMotivacionOutputPort
{
    IReadOnlyList<SelectMotivacionViewModel> SelectMotivacionViewModel { get; }
}