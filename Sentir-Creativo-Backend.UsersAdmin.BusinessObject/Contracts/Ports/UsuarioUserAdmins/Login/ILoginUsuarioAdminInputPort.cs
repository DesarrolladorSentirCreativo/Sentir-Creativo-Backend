namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Login
{
    public interface ILoginUsuarioAdminInputPort
    {
        ValueTask Handle(LoginUsuarioAdminDto dto);
    }
}
    

