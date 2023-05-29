using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetAll;

public interface IGetAllModuloOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllModuloViewModel> modelViews);
}