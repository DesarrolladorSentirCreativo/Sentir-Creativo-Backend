using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios;

public interface ICreatePrivilegioInputPort
{
    ValueTask Handle(CreatePrivilegioDto dto);
}