using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.TipoArchivo.Select;
using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.TipoArchivo;

public interface ISelectTipoArchivoPresenter : ISelectTipoArchivoOutputPort
{
    IReadOnlyList<SelectTipoArchivoViewModel> SelectTipoArchivo { get; }
}