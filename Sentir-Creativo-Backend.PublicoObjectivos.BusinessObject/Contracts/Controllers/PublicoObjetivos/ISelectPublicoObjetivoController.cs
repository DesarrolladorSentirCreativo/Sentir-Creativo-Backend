using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Controllers.PublicoObjetivos;

public interface ISelectPublicoObjetivoController
{
    ValueTask<IReadOnlyList<SelectPublicoObjetivoViewModel>> Handle();
}