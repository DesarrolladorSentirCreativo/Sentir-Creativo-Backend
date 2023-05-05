namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Update;

public interface IUpdateComentarioOutputPort
{
    ValueTask Handle(int comentarioId);
}