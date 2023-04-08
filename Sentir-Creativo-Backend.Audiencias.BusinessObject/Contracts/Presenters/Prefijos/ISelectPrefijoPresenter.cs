using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Prefijos.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Prefijos;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Prefijos;

public interface ISelectPrefijoPresenter: ISelectPrefijoOutputPort
{
    IReadOnlyList<SelectPrefijoViewModel> SelectPrefijoViewModel { get; }
}