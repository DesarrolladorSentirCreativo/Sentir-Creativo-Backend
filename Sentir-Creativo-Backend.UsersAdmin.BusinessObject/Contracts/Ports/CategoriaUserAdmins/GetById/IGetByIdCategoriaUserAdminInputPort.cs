namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.GetById;

public interface IGetByIdCategoriaUserAdminInputPort
{
    ValueTask Handle(int categoriaId);
}