namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Update;

public interface IUpdateUsuarioAdminInputPort
{
    ValueTask Handle(UpdateUsuarioAdminDto dto);
}