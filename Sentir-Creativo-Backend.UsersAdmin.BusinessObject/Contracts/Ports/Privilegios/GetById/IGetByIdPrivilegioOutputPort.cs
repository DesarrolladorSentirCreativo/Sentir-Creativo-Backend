namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetById;

public interface IGetByIdPrivilegioOutputPort
{
    ValueTask Handle(GetByIdPrivilegioViewModel modelView);
}