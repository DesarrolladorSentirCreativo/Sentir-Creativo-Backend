using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;

public interface IGetByIdSucursalController
{
    ValueTask<GetByIdSucursalViewModel> Handle(int sucursalId);
}