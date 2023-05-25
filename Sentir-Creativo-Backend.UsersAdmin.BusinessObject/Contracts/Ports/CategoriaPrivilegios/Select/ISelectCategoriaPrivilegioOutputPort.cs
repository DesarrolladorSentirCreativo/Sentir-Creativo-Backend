using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Select;

public interface ISelectCategoriaPrivilegioOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectCategoriaPrivilegioViewModel> modelViews);
}