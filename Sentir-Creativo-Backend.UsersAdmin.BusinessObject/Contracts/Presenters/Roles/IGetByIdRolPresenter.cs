namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;

public interface IGetByIdRolPresenter : IGetByIdRolOutputPort
{
    GetByIdRolViewModel ModelView { get; }
}