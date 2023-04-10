using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.TiposProyectos;

namespace Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Ports.TipoProyectos;

public interface ISelectTipoProyectoOutPort
{
    ValueTask Handle(IReadOnlyList<SelectTipoProyectoViewModel> modelView);
}