using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.GetAll;

public interface IGetAllAcuerdoUserAdminOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllAcuerdoUserAdminViewModel> modelViews);
}