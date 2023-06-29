namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;

public interface ICreateEstadoUserAdminPresenter : ICreateEstadoUserAdminOutputPort
{
    int EstadoId { get; }
}