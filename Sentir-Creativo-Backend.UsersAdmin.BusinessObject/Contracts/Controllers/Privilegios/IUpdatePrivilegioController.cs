using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;

public interface IUpdatePrivilegioController
{
    ValueTask<string> Handle(UpdatePrivilegioDto dto);
}