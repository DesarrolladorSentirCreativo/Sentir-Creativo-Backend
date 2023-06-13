namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.GetById;

public interface IGetByIdModoTrabajoInputPort
{
    ValueTask Handle(int modoTrabajoId);
}