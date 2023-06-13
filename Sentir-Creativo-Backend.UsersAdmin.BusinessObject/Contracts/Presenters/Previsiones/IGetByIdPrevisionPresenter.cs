using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;

public interface IGetByIdPrevisionPresenter : IGetByIdPrevisionOutputPort
{
    GetByIdPrevisionViewModel ViewModel { get; }
}