using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.TiposProyectos;

namespace Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Presenters.TipoProyectos;

public interface ISelectTipoProyectoPresenter : ISelectTipoProyectoOutPort
{
    IReadOnlyList<SelectTipoProyectoViewModel> SelectTipoProyectoViewModel { get; }
}