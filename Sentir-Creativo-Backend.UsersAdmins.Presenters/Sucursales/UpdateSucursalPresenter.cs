using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Sucursales;

public class UpdateSucursalPresenter : IUpdateSucursalPresenter
{
    public int SucursalId { get; private set; }
    
    public ValueTask Handle(int sucursalId)
    {
        SucursalId = sucursalId;

        return ValueTask.CompletedTask;
    }
    
}