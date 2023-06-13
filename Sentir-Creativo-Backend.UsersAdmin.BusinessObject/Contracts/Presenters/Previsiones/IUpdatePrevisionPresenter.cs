using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Update;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;

public interface IUpdatePrevisionPresenter : IUpdatePrevisionOutputPort
{
    int PrevisionId { get; }
}