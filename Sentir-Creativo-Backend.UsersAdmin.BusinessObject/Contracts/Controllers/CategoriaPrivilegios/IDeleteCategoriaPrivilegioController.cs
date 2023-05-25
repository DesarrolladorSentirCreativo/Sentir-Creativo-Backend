namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;

public interface IDeleteCategoriaPrivilegioController
{
    ValueTask<int> Handle(int categoriaPrivilegioId);
}