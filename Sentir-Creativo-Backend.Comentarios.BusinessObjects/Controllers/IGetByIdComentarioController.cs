using Sentir_Creativo_Backend.Comentarios.BusinessObjects.ViewModels;

namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Controllers;

public interface IGetByIdComentarioController
{
    ValueTask<GetByIdComentarioViewModel> Handle(int comentarioId);
}