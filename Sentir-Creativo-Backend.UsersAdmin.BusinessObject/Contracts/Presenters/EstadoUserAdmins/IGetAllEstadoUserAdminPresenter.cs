namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;

public interface IGetAllEstadoUserAdminPresenter : IGetAllEstadoUserAdminOutputPort
{
    IReadOnlyList<GetAllEstadoUserAdminViewModel> ViewModels { get;  }
}