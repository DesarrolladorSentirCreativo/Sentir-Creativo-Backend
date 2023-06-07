using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;

public interface IGeAllAcuerdoUserAdminPresenter : IGetAllAcuerdoUserAdminOutputPort
{
    IReadOnlyList<GetAllAcuerdoUserAdminViewModel> ModelViews { get; }
}