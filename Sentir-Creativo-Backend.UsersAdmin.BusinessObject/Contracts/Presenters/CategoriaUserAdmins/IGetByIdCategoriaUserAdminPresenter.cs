using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;

public interface IGetByIdCategoriaUserAdminPresenter : IGetByIdCategoriaUserAdminOutputPort
{
    GetByIdCategoriaUserAdminViewModel ViewModel { get; }
}