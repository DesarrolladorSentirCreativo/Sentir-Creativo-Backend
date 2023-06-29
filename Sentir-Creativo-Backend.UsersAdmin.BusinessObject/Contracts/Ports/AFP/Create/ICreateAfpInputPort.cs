namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Create;

public interface ICreateAfpInputPort
{
    ValueTask Handle(CreateAfpDto dto);
}