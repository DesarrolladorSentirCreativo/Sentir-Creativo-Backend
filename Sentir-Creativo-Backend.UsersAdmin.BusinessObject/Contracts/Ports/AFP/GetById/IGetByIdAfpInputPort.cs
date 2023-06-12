namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.GetById;

public interface IGetByIdAfpInputPort
{
    ValueTask Handle(int afpId);
}