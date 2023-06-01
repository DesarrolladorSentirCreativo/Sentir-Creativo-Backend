using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;

public interface ISelectPrivilegioPresenter : ISelectPrivilegioOutputPort
{
    IReadOnlyList<SelectPrivilegioViewModel> ModelViews { get; }
}