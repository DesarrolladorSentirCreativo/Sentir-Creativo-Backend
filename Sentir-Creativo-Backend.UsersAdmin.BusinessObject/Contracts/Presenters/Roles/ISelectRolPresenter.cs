namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;

public interface ISelectRolPresenter : ISelectRolOutputPort
{
    IReadOnlyList<SelectRolViewModel> ModelViews { get; }
}