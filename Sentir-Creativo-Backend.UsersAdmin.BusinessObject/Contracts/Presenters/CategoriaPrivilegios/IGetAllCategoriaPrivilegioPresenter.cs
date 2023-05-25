using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;

public interface IGetAllCategoriaPrivilegioPresenter : IGetAllCategoriaPrivilegioOutputPort
{
    IReadOnlyList<GetAllCategoriaPrivilegioViewModel> ModelViews { get; }
}