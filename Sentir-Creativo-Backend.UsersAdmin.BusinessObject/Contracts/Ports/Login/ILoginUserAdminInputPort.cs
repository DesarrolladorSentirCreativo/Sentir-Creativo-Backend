namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;

public interface ILoginUserAdminInputPort
{
    ValueTask Handle(LoginUserAdminDto dto);
}