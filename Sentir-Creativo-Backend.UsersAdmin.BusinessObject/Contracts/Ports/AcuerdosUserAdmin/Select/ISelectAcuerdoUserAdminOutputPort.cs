using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Select;

public interface ISelectAcuerdoUserAdminOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectAcuerdoUserAdminViewModel> modelViews);
}