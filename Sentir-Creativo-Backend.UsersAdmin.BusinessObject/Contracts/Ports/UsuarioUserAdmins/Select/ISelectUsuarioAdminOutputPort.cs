using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Select;

public interface ISelectUsuarioAdminOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectUsuarioAdminViewModel> viewModels);
}