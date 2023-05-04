using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Presenters;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.ViewModels;

namespace Sentir_Creativo_Backend.Comentarios.Presenters.Comentarios;

public class GetByIdComentarioPresenter : IGetByIdComentarioPresenter
{
    public GetByIdComentarioViewModel GetByIdComentarioViewModel { get; private set; }
    
    public ValueTask Handle(GetByIdComentarioViewModel viewModel)
    {
        GetByIdComentarioViewModel = viewModel;

        return ValueTask.CompletedTask;
    }
}