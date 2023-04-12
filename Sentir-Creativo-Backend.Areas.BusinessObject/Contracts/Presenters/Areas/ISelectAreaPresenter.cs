using Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Ports.Areas.Select;
using Sentir_Creativo_Backend.Areas.BusinessObject.ViewModels.Areas;

namespace Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Presenters.Areas;

public interface ISelectAreaPresenter : ISelectAreaOutputPort
{
    IReadOnlyList<SelectAreaViewModel> SelectAreaViewModel { get; }
}