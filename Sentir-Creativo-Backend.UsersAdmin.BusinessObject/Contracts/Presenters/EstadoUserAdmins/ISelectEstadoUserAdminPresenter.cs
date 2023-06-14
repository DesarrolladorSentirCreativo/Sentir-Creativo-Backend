using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;

public interface ISelectEstadoUserAdminPresenter : ISelectEstadoUserAdminOutputPort
{
    IReadOnlyList<SelectEstadoUserAdminViewModel> ViewModels { get; }
}