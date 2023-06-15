namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Create;

public interface ICreateUsuarioAdminOutputPort
{
    ValueTask Handle(int usuarioAdminId);
}