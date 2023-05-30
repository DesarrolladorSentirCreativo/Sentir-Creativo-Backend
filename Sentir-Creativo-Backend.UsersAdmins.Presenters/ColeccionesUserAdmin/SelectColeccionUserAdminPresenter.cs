using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.ColeccionesUserAdmin;

public class SelectColeccionUserAdminPresenter : ISelectColeccionUserAdminAdminPresenter
{
    public IReadOnlyList<SelectColeccionUserAdminViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectColeccionUserAdminViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
}