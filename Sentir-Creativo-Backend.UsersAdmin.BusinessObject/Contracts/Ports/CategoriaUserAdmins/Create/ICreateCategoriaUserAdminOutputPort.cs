namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Create;

public interface ICreateCategoriaUserAdminOutputPort
{
    ValueTask Handle(int categoriaId);
}