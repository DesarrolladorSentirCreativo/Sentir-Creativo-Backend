namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Select;

public interface ISelectCategoriaPrivilegioOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectCategoriaPrivilegioViewModel> modelViews);
}