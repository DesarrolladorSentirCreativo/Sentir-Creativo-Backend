using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;

public interface ISelectCategoriaUserAdminPresenter : ISelectCategoriaUserAdminOutputPort
{
    IReadOnlyList<SelectCategoriaUserAdminViewModel> ViewModels { get; }
}