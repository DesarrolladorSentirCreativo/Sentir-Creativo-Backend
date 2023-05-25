namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetById;

public interface IGetByIdCategoriaPrivilegioInputPort
{
    ValueTask Handle(int categoriaPrivilegioId);
}