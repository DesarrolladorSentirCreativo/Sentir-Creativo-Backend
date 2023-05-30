using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.ColeccionesUserAdmin;

public class GetAllColeccionUserAdminPresenter : IGetAllColeccionUserAdminPresenter
{
    public IReadOnlyList<GetAllColeccionUserAdminViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<GetAllColeccionUserAdminViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
    
}