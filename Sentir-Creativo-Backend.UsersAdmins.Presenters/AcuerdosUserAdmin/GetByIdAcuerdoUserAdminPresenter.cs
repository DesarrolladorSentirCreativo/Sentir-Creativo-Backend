using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.AcuerdosUserAdmin;

public class GetByIdAcuerdoUserAdminPresenter : IGetByIdAcuerdoUserAdminPresenter
{
    public GetByIdAcuerdoUserAdminViewModel ModelView { get; private set; }
    
    public ValueTask Handle(GetByIdAcuerdoUserAdminViewModel modelView)
    {
        ModelView = modelView;
        
        return ValueTask.CompletedTask;
    }
    
}