using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Update;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;

public interface IUpdateUsuarioAdminPresenter : IUpdateUsuarioAdminOutputPort
{
    int UsuarioAdminId { get; }
}