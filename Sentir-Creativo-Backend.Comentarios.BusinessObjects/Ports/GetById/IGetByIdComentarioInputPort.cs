namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.GetById;

public interface IGetByIdComentarioInputPort
{
    ValueTask Handle(int comentarioId);
}