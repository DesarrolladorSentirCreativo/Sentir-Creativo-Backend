using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Sucursales;

public class DeleteSucursalPresenter : IDeleteSucursalPresenter
{
    public int SucursalId { get; private set; }
    
    public ValueTask Handle(int sucursalId)
    {
        SucursalId = sucursalId;
        
        return ValueTask.CompletedTask;
    }
    
}