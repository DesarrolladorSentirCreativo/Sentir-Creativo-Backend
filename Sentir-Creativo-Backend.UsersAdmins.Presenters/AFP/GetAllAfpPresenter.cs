using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.AFP;

public class GetAllAfpPresenter : IGetAllAfpPresenter
{
    public ValueTask Handle(IReadOnlyList<GetAllAfpViewModel> viewModels)
    {
        ViewModels = viewModels;
        
        return ValueTask.CompletedTask;
    }

    public IReadOnlyList<GetAllAfpViewModel> ViewModels { get; private set; }
}