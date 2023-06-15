namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;

public interface IDeleteUsuarioAdminController
{
    ValueTask<int> Handle(int usuarioAdminId);
}