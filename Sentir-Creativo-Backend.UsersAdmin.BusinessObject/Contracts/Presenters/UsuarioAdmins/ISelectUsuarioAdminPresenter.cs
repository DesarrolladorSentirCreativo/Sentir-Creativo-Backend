using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;

public interface ISelectUsuarioAdminPresenter : ISelectUsuarioAdminOutputPort
{
    IReadOnlyList<SelectUsuarioAdminViewModel> ViewModels { get; }
}