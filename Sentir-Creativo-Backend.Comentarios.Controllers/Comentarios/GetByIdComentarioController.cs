using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Controllers;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.GetById;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Presenters;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.ViewModels;

namespace Sentir_Creativo_Backend.Comentarios.Controllers.Comentarios;

public class GetByIdComentarioController : IGetByIdComentarioController
{
    private readonly IGetByIdComentarioInputPort _inputPort;
    private readonly IGetByIdComentarioPresenter _presenter;

    public GetByIdComentarioController(
        IGetByIdComentarioInputPort inputPort,
        IGetByIdComentarioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<GetByIdComentarioViewModel> Handle(int comentarioId)
    {
        await _inputPort.Handle(comentarioId);
        return _presenter.GetByIdComentarioViewModel;
    }
}