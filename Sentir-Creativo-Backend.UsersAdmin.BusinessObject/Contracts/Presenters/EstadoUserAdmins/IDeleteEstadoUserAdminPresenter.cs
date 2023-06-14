using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Delete;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;

public interface IDeleteEstadoUserAdminPresenter : IDeleteEstadoUserAdminOutputPort
{
    int EstadoId { get; }
}