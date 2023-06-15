using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.UsuarioAdmins;

public class CreateUsuarioAdminPresenter : ICreateUsuarioAdminPresenter
{
    public ValueTask Handle(int usuarioAdminId)
    {
        UsuarioAdminId = usuarioAdminId;
        
        return ValueTask.CompletedTask;
    }

    public int UsuarioAdminId { get; private set; }
}