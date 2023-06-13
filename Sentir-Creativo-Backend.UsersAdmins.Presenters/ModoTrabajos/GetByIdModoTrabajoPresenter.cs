using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.ModoTrabajos;

public class GetByIdModoTrabajoPresenter : IGetByIdModoTrabajoPresenter
{
    public GetByIdModoTrabajoViewModel ModelView { get; private set; }
    
    public ValueTask Handle(GetByIdModoTrabajoViewModel viewModel)
    {
        ModelView = viewModel;
        
        return ValueTask.CompletedTask;
    }
}