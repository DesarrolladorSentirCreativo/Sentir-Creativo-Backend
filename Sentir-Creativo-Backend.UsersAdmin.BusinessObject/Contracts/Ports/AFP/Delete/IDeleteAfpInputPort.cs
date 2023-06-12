namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Delete;

public interface IDeleteAfpInputPort
{
    ValueTask Handle(int afpId);
}