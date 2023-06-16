using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;

public interface IGetByIdUsuarioAdminPresenter : IGetByIdUsuarioAdminOutputPort
{
    GetByIdUsuarioAdminViewModel ViewModel { get; }
}