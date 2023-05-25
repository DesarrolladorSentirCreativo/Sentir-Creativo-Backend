using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaPrivilegios;

public class GetAllCategoriaPrivilegioPresenter : IGetAllCategoriaPrivilegioPresenter
{
    public IReadOnlyList<GetAllCategoriaPrivilegioViewModel> ModelViews { get; private set; }


    public ValueTask Handle(IReadOnlyList<GetAllCategoriaPrivilegioViewModel> viewModels)
    {
        ModelViews = viewModels;
        
        return ValueTask.CompletedTask;
    }
}