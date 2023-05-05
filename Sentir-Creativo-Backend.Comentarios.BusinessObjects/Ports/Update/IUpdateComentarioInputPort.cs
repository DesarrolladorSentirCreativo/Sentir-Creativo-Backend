using Sentir_Creativo_Backend.Comentarios.BusinessObjects.DTO;

namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.Update;

public interface IUpdateComentarioInputPort
{
    ValueTask Handle(UpdateComentarioDto dto);
}