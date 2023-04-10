using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.EstadoProyectos;

namespace Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Controllers.EstadoProyectos;

public interface ISelectEstadoProyectoController
{
    ValueTask<IReadOnlyList<SelectEstadoProyectoViewModel>> Handle();
}