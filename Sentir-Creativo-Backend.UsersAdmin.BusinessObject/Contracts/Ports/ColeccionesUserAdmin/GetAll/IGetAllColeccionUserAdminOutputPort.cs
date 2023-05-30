using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.GetAll;

public interface IGetAllColeccionUserAdminOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllColeccionUserAdminViewModel> modelViews);
}