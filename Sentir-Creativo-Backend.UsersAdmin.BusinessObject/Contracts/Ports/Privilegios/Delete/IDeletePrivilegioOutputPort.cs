namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Delete;

public interface IDeletePrivilegioOutputPort
{
    ValueTask Handle(string privilegioId);
}