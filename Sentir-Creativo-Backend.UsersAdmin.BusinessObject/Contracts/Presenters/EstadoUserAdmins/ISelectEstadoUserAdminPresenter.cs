namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;

public interface ISelectEstadoUserAdminPresenter : ISelectEstadoUserAdminOutputPort
{
    IReadOnlyList<SelectEstadoUserAdminViewModel> ViewModels { get; }
}