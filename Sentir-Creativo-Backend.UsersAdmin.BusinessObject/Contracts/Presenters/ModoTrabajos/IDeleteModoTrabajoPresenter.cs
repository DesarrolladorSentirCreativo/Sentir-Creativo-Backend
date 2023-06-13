using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Delete;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;

public interface IDeleteModoTrabajoPresenter : IDeleteModoTrabajoOutputPort
{
    int ModoTrabajoId { get; }
}