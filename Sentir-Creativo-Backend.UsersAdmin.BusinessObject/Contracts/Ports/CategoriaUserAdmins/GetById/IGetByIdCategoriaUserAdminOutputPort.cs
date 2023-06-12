using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.GetById;

public interface IGetByIdCategoriaUserAdminOutputPort
{
    ValueTask Handle(GetByIdCategoriaUserAdminViewModel viewModel);
}