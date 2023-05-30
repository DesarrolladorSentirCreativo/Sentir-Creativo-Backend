using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.ColeccionesUserAdmin;

public class GetByIdColeccionUserAdminPresenter : IGetByIdColeccionUserAdminPresenter
{
    public GetByIdColeccionUserAdminViewModel GetByIdColeccionUserAdminViewModel { get; private set; }
    
    public ValueTask Handle(GetByIdColeccionUserAdminViewModel getByIdColeccionUserAdminViewModel)
    {
        GetByIdColeccionUserAdminViewModel = getByIdColeccionUserAdminViewModel;
        
        return ValueTask.CompletedTask;
    }
}