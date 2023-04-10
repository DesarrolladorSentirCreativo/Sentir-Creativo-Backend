using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.EstadoProyectos;

namespace Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports.EstadoProyectos.Select;

public interface ISelectEstadoProyectoOuputPort
{
    ValueTask Handle(IReadOnlyList<SelectEstadoProyectoViewModel> modelView);
}