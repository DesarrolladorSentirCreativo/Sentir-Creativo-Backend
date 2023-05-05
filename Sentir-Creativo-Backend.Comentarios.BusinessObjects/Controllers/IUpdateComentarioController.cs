using Sentir_Creativo_Backend.Comentarios.BusinessObjects.DTO;

namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Controllers;

public interface IUpdateComentarioController
{
    ValueTask<int> Handle(UpdateComentarioDto dto);
}