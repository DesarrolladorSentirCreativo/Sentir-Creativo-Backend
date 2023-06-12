namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Update;

public interface IUpdateAfpOutputPort
{
    ValueTask Handle(int afpId);
}