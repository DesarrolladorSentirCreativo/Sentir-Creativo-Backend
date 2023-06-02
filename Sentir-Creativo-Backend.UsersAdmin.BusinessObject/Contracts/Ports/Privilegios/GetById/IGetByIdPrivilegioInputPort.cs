namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetById;

public interface IGetByIdPrivilegioInputPort
{
    ValueTask Handle(string privilegiId);
}