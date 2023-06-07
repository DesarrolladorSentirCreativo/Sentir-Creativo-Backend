using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.AcuerdosUserAdmin;

public class SelectAcuerdoUserAdminPresenter : ISelectAcuerdoUserAdminPresenter
{
    public IReadOnlyList<SelectAcuerdoUserAdminViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectAcuerdoUserAdminViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
}