using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.TiposProyectos;

namespace Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Controllers.TipoProyectos;

public interface ISelectTipoProyectoController
{
    ValueTask<IReadOnlyList<SelectTipoProyectoViewModel>> Handle();
}