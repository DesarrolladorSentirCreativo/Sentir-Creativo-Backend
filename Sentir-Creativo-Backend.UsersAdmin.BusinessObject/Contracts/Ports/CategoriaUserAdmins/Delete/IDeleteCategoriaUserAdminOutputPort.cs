namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Delete;

public interface IDeleteCategoriaUserAdminOutputPort
{
    ValueTask Handle(int categoriaId);
}