namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;

public interface ILoginUserAdminOutputPort
{
    ValueTask Handle(UserAdminTokenViewModel viewModel);
}