namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Delete;

public interface IDeleteUsuarioAdminInputPort
{
    ValueTask Handle(int usuarioAdminId);
}