using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;

public interface ISelectCategoriaPrivilegioPresenter : ISelectCategoriaPrivilegioOutputPort
{
    IReadOnlyList<SelectCategoriaPrivilegioViewModel> ModelViews { get; }
}