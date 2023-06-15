using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Delete;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;

public interface IDeleteUsuarioAdminPresenter : IDeleteUsuarioAdminOutputPort
{
    int UsuarioAdminId { get; }
}