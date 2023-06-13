using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Create;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;

public interface ICreateModoTrabajoPresenter : ICreateModoTrabajoOutputPort
{
    int ModoTrabajoId { get; }
}