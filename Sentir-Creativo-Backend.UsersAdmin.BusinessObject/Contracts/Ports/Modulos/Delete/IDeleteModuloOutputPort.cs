namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Delete;

public interface IDeleteModuloOutputPort
{
    ValueTask Handle(int moduloId);
}