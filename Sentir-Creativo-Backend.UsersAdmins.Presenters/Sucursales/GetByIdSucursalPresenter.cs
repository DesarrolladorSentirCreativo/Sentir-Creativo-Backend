using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Sucursales;

public class GetByIdSucursalPresenter : IGetByIdSucursalPresenter
{
    public GetByIdSucursalViewModel ModelView { get; private set; }
    
    public ValueTask Handle(GetByIdSucursalViewModel modelView)
    {
        ModelView = modelView;
        
        return ValueTask.CompletedTask;
    }
}