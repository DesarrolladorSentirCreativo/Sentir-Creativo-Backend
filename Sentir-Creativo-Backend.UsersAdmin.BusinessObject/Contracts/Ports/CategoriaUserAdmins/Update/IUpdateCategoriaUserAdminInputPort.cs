using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Update;

public interface IUpdateCategoriaUserAdminInputPort
{
    ValueTask Handle(UpdateCategoriaUserAdminDto dto);
}