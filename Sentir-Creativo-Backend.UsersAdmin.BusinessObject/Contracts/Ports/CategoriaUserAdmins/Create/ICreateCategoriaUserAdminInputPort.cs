using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Create;

public interface ICreateCategoriaUserAdminInputPort
{
    ValueTask Handle(CreateCategoriaUserAdminDto dto);
}