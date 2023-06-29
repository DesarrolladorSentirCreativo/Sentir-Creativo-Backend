namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Update;

public interface IUpdateModoTrabajoInputPort
{
    ValueTask Handle(UpdateModoTrabajoDto dto);
}