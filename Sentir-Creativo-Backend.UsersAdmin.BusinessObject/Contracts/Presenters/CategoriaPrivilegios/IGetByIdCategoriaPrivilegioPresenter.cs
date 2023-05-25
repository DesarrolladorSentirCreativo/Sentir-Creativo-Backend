using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;

public interface IGetByIdCategoriaPrivilegioPresenter : IGetByIdCategoriaPrivilegioOutputPort
{
    GetByIdCategoriaPrivilegioViewModel ModelView { get; }
}