namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios;

public interface ICreatePrivilegioOutputPort
{
    ValueTask Handle(string privilegioId);
}