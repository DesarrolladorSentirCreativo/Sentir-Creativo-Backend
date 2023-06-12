namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Delete;

public interface IDeleteAfpOutputPort
{
    ValueTask Handle(int afpId);
}