using Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Update;

public interface IUpdateArchivoInputPort
{
    ValueTask Handle(UpdateArchivoDto dto);
}