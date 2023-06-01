using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Privilegios;

public class CreatePrivilegioPresenter : ICreatePrivilegioPresenter
{
    public string PrivilegioId { get; private set; }
    
    public ValueTask Handle(string privilegioId)
    {
        PrivilegioId = privilegioId;
        
        return ValueTask.CompletedTask;
    }
    
}