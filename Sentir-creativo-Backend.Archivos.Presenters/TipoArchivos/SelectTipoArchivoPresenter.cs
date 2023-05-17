using Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.TipoArchivo;
using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_creativo_Backend.Archivos.Presenters.TipoArchivos;

public class SelectTipoArchivoPresenter : ISelectTipoArchivoPresenter
{
    public IReadOnlyList<SelectTipoArchivoViewModel> SelectTipoArchivo { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectTipoArchivoViewModel> viewModel)
    {
       SelectTipoArchivo = viewModel;

       return ValueTask.CompletedTask;
    }
    
}