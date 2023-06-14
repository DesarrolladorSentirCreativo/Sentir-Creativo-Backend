using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;

public interface IGetAllEstadoUserAdminPresenter : IGetAllEstadoUserAdminOutputPort
{
    IReadOnlyList<GetAllEstadoUserAdminViewModel> ViewModels { get;  }
}