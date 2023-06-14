using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.EstadoUserAdmins;

public interface IGetByIdEstadoUserAdminPresenter : IGetByIdEstadoUserAdminOutputPort
{
    GetByIdEstadoUserAdminViewModel ViewModel { get; }
}