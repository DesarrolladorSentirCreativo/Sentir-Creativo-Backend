using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.AcuerdosUserAdmin;

public class GetAllAcuerdoUserAdminPresenter : IGeAllAcuerdoUserAdminPresenter
{
    public IReadOnlyList<GetAllAcuerdoUserAdminViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<GetAllAcuerdoUserAdminViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
    
}