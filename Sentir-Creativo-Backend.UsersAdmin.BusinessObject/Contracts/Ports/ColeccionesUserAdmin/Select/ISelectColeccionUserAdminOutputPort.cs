namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Select;

public interface ISelectColeccionUserAdminOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectColeccionUserAdminViewModel> modelViews);
}