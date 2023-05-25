namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Delete;

public interface IDeleteCategoriaPrivilegioOutputPort
{
    ValueTask Handle(int categoriaPrivilegioId);
}