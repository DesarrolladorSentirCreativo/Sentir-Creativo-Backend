using Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.Archivos;

public interface IUpdateArchivoController
{
    ValueTask<int> Handle(UpdateArchivoDto dto);
}