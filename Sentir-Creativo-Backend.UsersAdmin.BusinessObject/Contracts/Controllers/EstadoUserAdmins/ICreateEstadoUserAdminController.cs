using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;

public interface ICreateEstadoUserAdminController
{
    ValueTask<int> Handle(CreateEstadoUserAdminDto dto);
}