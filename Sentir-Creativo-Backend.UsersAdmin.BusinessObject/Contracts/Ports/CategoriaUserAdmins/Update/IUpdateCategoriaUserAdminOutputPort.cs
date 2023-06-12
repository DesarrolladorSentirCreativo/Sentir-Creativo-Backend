namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Update;

public interface IUpdateCategoriaUserAdminOutputPort
{
    ValueTask Handle(int categoriaId);
}