using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaPrivilegios;

public class CreateCategoryPrivilegioPresenter : ICreateCategoriaPrivilegioPresenter
{
    public int CategoriaPrivilegioId { get; private set; }
    
    public ValueTask Handle(int categoriaPrivilegioId)
    {
        CategoriaPrivilegioId = categoriaPrivilegioId;
        
        return ValueTask.CompletedTask;
    }
}