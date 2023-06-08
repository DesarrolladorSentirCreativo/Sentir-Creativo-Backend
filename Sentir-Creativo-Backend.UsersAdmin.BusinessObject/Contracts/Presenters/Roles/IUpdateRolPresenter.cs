using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Update;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;

public interface IUpdateRolPresenter : IUpdateRolOutputPort
{
    int RolId { get; }
}