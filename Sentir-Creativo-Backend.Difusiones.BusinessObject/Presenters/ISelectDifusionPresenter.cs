using Sentir_Creativo_Backend.Difusiones.BusinessObject.Ports;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Difusiones.BusinessObject.Presenters;

public interface ISelectDifusionPresenter : ISelectDifusionOutputPort
{
    IReadOnlyList<SelectDifusionViewModel> SelectDifusionViewModels { get;  }
}