using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaPrivilegios;

public class GetByIdCategoriaPrivilegioPresenter : IGetByIdCategoriaPrivilegioPresenter
{
    public GetByIdCategoriaPrivilegioViewModel ModelView { get; private set; }
    
    public ValueTask Handle(GetByIdCategoriaPrivilegioViewModel modelView)
    {
        ModelView = modelView;
        
        return ValueTask.CompletedTask;
    }
}