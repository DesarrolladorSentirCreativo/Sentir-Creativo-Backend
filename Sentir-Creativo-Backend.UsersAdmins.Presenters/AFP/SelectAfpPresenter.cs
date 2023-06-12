using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.AFP;

public class SelectAfpPresenter : ISelectAfpPresenter
{
    public ValueTask Handle(IReadOnlyList<SelectAfpViewModel> viewModels)
    {
        ViewModels = viewModels;
        
        return ValueTask.CompletedTask;
    }

    public IReadOnlyList<SelectAfpViewModel> ViewModels { get; private set; }
}