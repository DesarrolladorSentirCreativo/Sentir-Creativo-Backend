namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Create;

public interface ICreateUsuarioAdminInputPort
{
    ValueTask Handle(CreateUsuarioAdminDto dto);
}