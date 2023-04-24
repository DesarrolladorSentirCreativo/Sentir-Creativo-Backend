using Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.Archivos;

public interface ICreateArchivoController
{
    ValueTask<int> Handle(CreateArchivoDto dto);
}