using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;

public interface IGetAllPrevisionPresenter : IGetAllPrevisionOutputPort
{
    IReadOnlyList<GetAllPrevisionViewModel> ViewModels { get; }
}