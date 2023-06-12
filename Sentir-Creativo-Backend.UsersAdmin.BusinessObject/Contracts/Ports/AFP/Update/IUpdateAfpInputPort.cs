using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AFP;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Update;

public interface IUpdateAfpInputPort
{
    ValueTask Handle(UpdateAfpDto dto);
}