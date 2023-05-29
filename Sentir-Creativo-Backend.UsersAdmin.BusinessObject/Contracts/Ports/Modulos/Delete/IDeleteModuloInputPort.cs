namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Delete;

public interface IDeleteModuloInputPort
{
    ValueTask Handle(int moduloId);
}