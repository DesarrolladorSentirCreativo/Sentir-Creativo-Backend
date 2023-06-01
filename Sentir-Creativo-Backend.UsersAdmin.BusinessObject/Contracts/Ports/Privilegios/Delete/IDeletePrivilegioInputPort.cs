namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Delete;

public interface IDeletePrivilegioInputPort
{
    ValueTask Handle(string privilegioId);
}