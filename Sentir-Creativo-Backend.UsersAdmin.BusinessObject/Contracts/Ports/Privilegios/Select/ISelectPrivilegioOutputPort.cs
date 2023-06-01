using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Select;

public interface ISelectPrivilegioOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectPrivilegioViewModel> modelViews);
}