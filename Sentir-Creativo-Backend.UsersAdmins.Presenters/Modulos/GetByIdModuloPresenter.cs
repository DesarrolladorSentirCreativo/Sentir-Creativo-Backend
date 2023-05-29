using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Modulos;

public class GetByIdModuloPresenter : IGetByIdModuloPresenter
{
    public GetByIdModuloViewModel ModelView { get; private set; }
    
    public ValueTask Handle(GetByIdModuloViewModel modelView)
    {
        ModelView = modelView;
        
        return ValueTask.CompletedTask;
    }
}