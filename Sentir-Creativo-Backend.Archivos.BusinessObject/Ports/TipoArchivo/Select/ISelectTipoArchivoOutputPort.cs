using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.TipoArchivo.Select;

public interface ISelectTipoArchivoOutputPort 
{
    ValueTask Handle(IReadOnlyList<SelectTipoArchivoViewModel> viewModel);
}