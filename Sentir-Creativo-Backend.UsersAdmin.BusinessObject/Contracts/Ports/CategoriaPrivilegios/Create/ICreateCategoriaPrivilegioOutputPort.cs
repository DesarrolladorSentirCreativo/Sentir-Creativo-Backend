namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Create;

public interface ICreateCategoriaPrivilegioOutputPort
{
    ValueTask Handle(int categoriaPrivilegioId);
}