namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetById;

public interface IGetByIdCategoriaPrivilegioOutputPort
{
    ValueTask Handle(GetByIdCategoriaPrivilegioViewModel modelView);
}