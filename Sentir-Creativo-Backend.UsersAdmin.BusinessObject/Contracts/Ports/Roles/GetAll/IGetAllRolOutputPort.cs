namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.GetAll;

public interface IGetAllRolOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllRolViewModel> modelViews);
}