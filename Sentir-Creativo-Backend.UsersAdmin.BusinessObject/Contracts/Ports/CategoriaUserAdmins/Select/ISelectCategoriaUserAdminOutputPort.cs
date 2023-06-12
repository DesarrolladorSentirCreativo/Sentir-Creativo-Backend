using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Select;

public interface ISelectCategoriaUserAdminOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectCategoriaUserAdminViewModel> viewModels);
}