using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Controllers;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.DTO;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Update;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Presenters;

namespace Sentir_Creativo_Backend.Comentarios.Controllers.Comentarios;

public class UpdateComentarioController : IUpdateComentarioController
{
    private readonly IUpdateComentarioInputPort _inputPort;
    private readonly IUpdateComentarioPresenter _presenter;
    
    public UpdateComentarioController(
        IUpdateComentarioInputPort inputPort, 
        IUpdateComentarioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(UpdateComentarioDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.ComentarioId;
    }
}