using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Sucursales;

public class GetAllSucursalPresenter : IGetAllSucursalPresenter
{
    public IReadOnlyList<GetAllSucursalViewModel> ModelViews { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<GetAllSucursalViewModel> modelViews)
    {
        ModelViews = modelViews;

        return ValueTask.CompletedTask;
    }
}