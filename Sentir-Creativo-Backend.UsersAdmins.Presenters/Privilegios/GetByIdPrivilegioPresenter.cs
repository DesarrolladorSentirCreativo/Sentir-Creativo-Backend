using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Privilegios;

public class GetByIdPrivilegioPresenter : IGetByIdPrivilegioPresenter
{
    public GetByIdPrivilegioViewModel ModelView { get; private set; }
    
    public ValueTask Handle(GetByIdPrivilegioViewModel modelView)
    {
        ModelView = modelView;
        
        return ValueTask.CompletedTask;
    }
    
}