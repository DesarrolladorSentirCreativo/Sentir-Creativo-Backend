using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;

public interface IGetAllPrivilegioPresenter : IGetAllPrivilegioOutputPort
{
    IReadOnlyList<GetAllPrivilegioViewModel> ModelViews { get; }
}