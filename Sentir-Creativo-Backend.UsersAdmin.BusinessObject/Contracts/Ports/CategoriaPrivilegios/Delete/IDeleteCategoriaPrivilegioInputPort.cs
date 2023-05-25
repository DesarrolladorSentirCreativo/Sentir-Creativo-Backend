namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Delete;

public interface IDeleteCategoriaPrivilegioInputPort
{
    ValueTask Handle(int categoriaPrivilegioId);
}