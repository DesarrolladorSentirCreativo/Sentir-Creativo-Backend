namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;

public interface IUpdateUsuarioAdminController
{
    ValueTask<int> Handle(UpdateUsuarioAdminDto dto);
}