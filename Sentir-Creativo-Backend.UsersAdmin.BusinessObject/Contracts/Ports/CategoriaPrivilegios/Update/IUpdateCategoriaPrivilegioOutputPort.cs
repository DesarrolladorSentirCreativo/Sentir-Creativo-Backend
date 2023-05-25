namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Update;

public interface IUpdateCategoriaPrivilegioOutputPort
{
    ValueTask Handle(int categoriaPrivilegioId);
}