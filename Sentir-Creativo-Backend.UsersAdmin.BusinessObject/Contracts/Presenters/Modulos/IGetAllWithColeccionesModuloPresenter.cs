using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetAllWithColecciones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;

public interface IGetAllWithColeccionesModuloPresenter : IGetAllWithColeccionesModuloOutputPort
{
    IReadOnlyList<GetAllWithColeccionesModuloViewModel> ModelViews { get; }
}