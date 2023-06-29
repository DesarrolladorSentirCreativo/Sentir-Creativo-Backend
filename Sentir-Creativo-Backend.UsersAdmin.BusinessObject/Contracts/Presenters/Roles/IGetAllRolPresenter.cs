namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;

public interface IGetAllRolPresenter : IGetAllRolOutputPort
{
    IReadOnlyList<GetAllRolViewModel> ModelViews { get; }
}