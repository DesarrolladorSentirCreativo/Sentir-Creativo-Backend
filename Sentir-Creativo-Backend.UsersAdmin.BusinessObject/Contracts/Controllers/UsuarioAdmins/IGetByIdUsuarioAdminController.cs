namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;

public interface IGetByIdUsuarioAdminController
{
    ValueTask<GetByIdUsuarioAdminViewModel> Handle(int usuarioAdminId);
}