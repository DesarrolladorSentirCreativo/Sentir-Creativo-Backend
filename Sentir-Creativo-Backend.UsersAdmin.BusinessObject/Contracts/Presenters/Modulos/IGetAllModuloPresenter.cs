using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;

public interface IGetAllModuloPresenter : IGetAllModuloOutputPort
{
    IReadOnlyList<GetAllModuloViewModel> ModelViews { get; }
}