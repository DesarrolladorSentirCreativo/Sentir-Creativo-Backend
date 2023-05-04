using Senitr_Creativo_Backend.Comentarios.Entities.DTO;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Controllers;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Create;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Presenters;

namespace Sentir_Creativo_Backend.Comentarios.Controllers.Comentarios;

public class CreateComentarioController : ICreateComentarioController
{
    private readonly ICreateComentarioInputPort _inputPort;
    private readonly ICreateComentarioPresenter _presenter;

    public CreateComentarioController(ICreateComentarioInputPort inputPort, ICreateComentarioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(CreateComentarioDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.ComentarioId;
    }
}