using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Sucursales;

public class SelectSucursalPresenter : ISelectSucursalPresenter
{
    public IReadOnlyList<SelectSucursalViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectSucursalViewModel> modelViews)
    {
        ModelViews = modelViews;
        
        return ValueTask.CompletedTask;
    }
    
}