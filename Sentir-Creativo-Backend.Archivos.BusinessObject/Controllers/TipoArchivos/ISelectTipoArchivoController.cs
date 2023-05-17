using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.TipoArchivos;

public interface ISelectTipoArchivoController
{
    ValueTask<IReadOnlyList<SelectTipoArchivoViewModel>> Handle();
}