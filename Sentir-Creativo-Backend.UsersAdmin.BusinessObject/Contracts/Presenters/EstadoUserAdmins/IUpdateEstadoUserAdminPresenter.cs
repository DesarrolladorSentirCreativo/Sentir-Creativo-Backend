namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;

public interface IUpdateEstadoUserAdminPresenter : IUpdateEstadoUserAdminOutputPort
{
    int EstadoId { get; }
}