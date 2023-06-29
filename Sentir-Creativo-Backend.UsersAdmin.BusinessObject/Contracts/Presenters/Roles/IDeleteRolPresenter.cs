namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;

public interface IDeleteRolPresenter : IDeleteRolOutputPort
{
    int RolId { get; }
}