namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetById;

public interface IGetByIdModuloInputPort
{
    ValueTask Handle(int moduloId);
}