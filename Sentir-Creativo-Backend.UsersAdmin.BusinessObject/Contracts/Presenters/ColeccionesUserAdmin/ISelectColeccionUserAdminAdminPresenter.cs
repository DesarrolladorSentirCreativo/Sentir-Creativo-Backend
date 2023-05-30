using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;

public interface ISelectColeccionUserAdminAdminPresenter : ISelectColeccionUserAdminOutputPort
{
    IReadOnlyList<SelectColeccionUserAdminViewModel> ModelViews { get; }
}