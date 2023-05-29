namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Create;

public interface ICreateModuloOutputPort
{
    ValueTask Handle(int moduloId);
}