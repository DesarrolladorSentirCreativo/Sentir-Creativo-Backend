using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;

public interface IGetByIdAcuerdoUserAdminPresenter : IGetByIdAcuerdoUserAdminOutputPort
{
    GetByIdAcuerdoUserAdminViewModel ModelView { get; }
}