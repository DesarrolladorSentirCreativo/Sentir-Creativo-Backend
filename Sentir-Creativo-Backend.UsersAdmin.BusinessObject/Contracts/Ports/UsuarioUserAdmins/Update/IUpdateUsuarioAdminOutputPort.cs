namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Update;

public interface IUpdateUsuarioAdminOutputPort
{
    ValueTask Handle(int usuarioAdminId);
}