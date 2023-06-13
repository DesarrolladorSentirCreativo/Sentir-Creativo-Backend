using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;

public interface ISelectPrevisionPresenter : ISelectPrevisionOutputPort
{
    IReadOnlyList<SelectPrevisionViewModel> ViewModels { get; }
}