using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;

public interface ISelectAcuerdoUserAdminPresenter : ISelectAcuerdoUserAdminOutputPort
{
    IReadOnlyList<SelectAcuerdoUserAdminViewModel> ModelViews { get; }
}