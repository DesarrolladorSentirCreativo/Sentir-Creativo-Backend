namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Delete;

public interface IDeleteCategoriaUserAdminInputPort
{
    ValueTask Handle(int categoriaId);
}