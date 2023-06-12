using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaUserAdmins;

public class CreateCategoriaUserAdminPresenter : ICreateCategoriaUserAdminPresenter
{
    public int CategoriaId { get; private set; }
    
    public ValueTask Handle(int categoriaId)
    {
        CategoriaId = categoriaId;
        
        return ValueTask.CompletedTask;
    }
    
}