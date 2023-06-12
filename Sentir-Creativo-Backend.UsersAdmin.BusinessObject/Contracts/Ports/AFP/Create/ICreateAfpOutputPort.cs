namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Create;

public interface ICreateAfpOutputPort
{
    ValueTask Handle(int afpId);
}