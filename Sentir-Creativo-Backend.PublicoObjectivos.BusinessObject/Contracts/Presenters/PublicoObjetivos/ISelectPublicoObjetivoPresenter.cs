using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.Select;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Presenters.PublicoObjetivos;

public interface ISelectPublicoObjetivoPresenter : ISelectPublicoObjetivoOutputPort
{
    IReadOnlyList<SelectPublicoObjetivoViewModel> SelectPublicoObjetivoViewModel { get; }
}