namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.GetAll;

public interface IGetAllCategoriaUserAdminOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllCategoriaUserAdminViewModel> modelViews);
}