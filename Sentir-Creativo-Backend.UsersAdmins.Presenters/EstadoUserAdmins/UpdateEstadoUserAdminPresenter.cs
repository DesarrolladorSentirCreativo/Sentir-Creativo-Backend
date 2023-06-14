using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.EstadoUserAdmins;

public class UpdateEstadoUserAdminPresenter : IUpdateEstadoUserAdminPresenter
{
    public ValueTask Handle(int estadoId)
    {
        EstadoId = estadoId;
        
        return ValueTask.CompletedTask;
    }

    public int EstadoId { get; private set; }
}