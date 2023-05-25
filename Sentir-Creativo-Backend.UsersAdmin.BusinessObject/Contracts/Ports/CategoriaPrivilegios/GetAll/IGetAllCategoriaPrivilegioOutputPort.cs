using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetAll;

public interface IGetAllCategoriaPrivilegioOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllCategoriaPrivilegioViewModel> viewModels);
}