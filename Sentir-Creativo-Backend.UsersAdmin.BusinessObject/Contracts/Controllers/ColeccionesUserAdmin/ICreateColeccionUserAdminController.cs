using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;

public interface ICreateColeccionUserAdminController
{
    ValueTask<int> Handle(CreateColeccionUserAdminDto dto);
}