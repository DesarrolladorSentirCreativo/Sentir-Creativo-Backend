namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Update;

public interface IUpdatePrivilegioOutputPort
{
    ValueTask Handle(string privilegioId);
}