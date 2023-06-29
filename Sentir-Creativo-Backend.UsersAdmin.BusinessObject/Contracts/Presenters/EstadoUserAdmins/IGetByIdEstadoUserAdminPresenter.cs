namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;

public interface IGetByIdEstadoUserAdminPresenter : IGetByIdEstadoUserAdminOutputPort
{
    GetByIdEstadoUserAdminViewModel ViewModel { get; }
}