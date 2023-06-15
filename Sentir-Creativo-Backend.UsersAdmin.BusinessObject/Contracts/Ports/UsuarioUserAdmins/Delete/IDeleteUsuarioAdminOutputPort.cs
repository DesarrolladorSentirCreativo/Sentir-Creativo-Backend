namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Delete;

public interface IDeleteUsuarioAdminOutputPort
{
    ValueTask Handle(int usuarioAdminId);
}