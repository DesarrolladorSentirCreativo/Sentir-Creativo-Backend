using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.AcuerdosUserAdmin;

public class DeleteAcuerdoUserAdminPresenter : IDeleteAcuerdoUserAdminPresenter
{
    public int AcuerdoId { get; private set; }
    
    public ValueTask Handle(int acuerdoId)
    {
        AcuerdoId = acuerdoId;
        
        return ValueTask.CompletedTask;
    }
}