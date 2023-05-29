namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Update;

public interface IUpdateModuloOutputPort
{
    ValueTask Handle(int moduloId);
}