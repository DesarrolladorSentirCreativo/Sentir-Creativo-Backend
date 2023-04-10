using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports.EstadoProyectos.Select;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.EstadoProyectos;

namespace Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Presenters.EstadoProyectos;

public interface ISelectEstadoProyectoPresenter : ISelectEstadoProyectoOuputPort
{
    IReadOnlyList<SelectEstadoProyectoViewModel> SelectEstadoProyectoViewModel { get; }
}