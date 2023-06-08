using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Roles;

public interface IGetByIdRolPresenter : IGetByIdRolOutputPort
{
    GetByIdRolViewModel ModelView { get; }
}