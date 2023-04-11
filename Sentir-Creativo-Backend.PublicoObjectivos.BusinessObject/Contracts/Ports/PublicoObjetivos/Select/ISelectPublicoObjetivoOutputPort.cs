using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.Select;

public interface ISelectPublicoObjetivoOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectPublicoObjetivoViewModel> modelView);
}