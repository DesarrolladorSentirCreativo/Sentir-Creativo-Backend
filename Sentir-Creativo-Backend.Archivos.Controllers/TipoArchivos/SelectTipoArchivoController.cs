using Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.TipoArchivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.TipoArchivo.Select;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.TipoArchivo;
using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Archivos.Controllers.TipoArchivos;

public class SelectTipoArchivoController : ISelectTipoArchivoController
{
    private readonly ISelectTipoArchivoInputPort _inputPort;
    private readonly ISelectTipoArchivoPresenter _presenter;
    
    public SelectTipoArchivoController(
        ISelectTipoArchivoInputPort inputPort, 
        ISelectTipoArchivoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectTipoArchivoViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.SelectTipoArchivo;
    }
}