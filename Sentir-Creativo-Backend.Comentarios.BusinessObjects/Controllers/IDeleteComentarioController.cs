namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Controllers;

public interface IDeleteComentarioController
{
    ValueTask<int> Handle(int comentarioId);
}