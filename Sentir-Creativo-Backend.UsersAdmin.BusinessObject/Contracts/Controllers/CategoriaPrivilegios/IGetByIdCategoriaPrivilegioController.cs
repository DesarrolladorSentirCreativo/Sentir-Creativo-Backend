namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;

public interface IGetByIdCategoriaPrivilegioController
{
    ValueTask<GetByIdCategoriaPrivilegioViewModel> Handle(int categoriaPrivilegioId);
}