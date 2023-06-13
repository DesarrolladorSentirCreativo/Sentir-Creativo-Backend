using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Update;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;

public interface IUpdateModoTrabajoPresenter : IUpdateModoTrabajoOutputPort
{
    int ModoTrabajoId { get; }
}