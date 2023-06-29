namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Create;

public interface ICreateCategoriaPrivilegioInputPort
{
    ValueTask Handle(CreateCategoriaPrivilegioDto dto);
}