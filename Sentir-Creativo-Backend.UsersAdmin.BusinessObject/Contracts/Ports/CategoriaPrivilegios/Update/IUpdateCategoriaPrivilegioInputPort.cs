namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Update;

public interface IUpdateCategoriaPrivilegioInputPort
{
    ValueTask Handle(UpdateCategoriaPrivilegioDto dto);
}