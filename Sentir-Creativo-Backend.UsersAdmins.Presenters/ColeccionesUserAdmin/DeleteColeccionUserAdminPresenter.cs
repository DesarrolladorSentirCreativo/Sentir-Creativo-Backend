using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.ColeccionesUserAdmin;

public class DeleteColeccionUserAdminPresenter : IDeleteColeccionUserAdminPresenter
{
    public int ColeccionUserAdminId { get; private set; }
    
    public ValueTask Handle(int coleccionUserAdminId)
    {
        ColeccionUserAdminId = coleccionUserAdminId;
        
        return ValueTask.CompletedTask;
    }
}