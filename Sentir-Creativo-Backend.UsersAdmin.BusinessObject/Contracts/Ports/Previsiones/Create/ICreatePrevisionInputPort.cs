using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Create;

public interface ICreatePrevisionInputPort
{
    ValueTask Handle(CreatePrevisionDto dto);
}