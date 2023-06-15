using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Create;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;

public interface ICreateUsuarioAdminPresenter : ICreateUsuarioAdminOutputPort
{
    int UsuarioAdminId { get; }
}