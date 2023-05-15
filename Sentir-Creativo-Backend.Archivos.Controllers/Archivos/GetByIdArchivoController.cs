using Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.Archivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.GetById;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.Archivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Archivos.Controllers.Archivos;

public class GetByIdArchivoController : IGetByIdArchivoController
{
    private readonly IGetByIdArchivoInputPort _inputPort;
    private readonly IGetByIdArchivoPresenter _presenter;

    public GetByIdArchivoController(
        IGetByIdArchivoInputPort inputPort,
        IGetByIdArchivoPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<GetByIdArchivoViewModel> Handle(int archivoId)
    {
        await _inputPort.Handle(archivoId);
        
        return _presenter.GetByIdArchivoViewModel;
    }
}