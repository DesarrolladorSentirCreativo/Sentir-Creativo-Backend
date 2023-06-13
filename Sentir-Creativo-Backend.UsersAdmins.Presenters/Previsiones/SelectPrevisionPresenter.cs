using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Previsiones;

public class SelectPrevisionPresenter : ISelectPrevisionPresenter
{
    public ValueTask Handle(IReadOnlyList<SelectPrevisionViewModel> viewModels)
    {
        ViewModels = viewModels;
        
        return ValueTask.CompletedTask;
    }

    public IReadOnlyList<SelectPrevisionViewModel> ViewModels { get; private set; }
}