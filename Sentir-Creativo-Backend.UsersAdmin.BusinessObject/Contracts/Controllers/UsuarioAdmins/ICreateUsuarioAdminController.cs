using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;

public interface ICreateUsuarioAdminController
{
    ValueTask<int> Handle(CreateUsuarioAdminDto dto);
}