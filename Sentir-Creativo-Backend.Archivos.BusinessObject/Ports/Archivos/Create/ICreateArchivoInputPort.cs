using Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Create;

public interface ICreateArchivoInputPort
{
    ValueTask Handle(CreateArchivoDto dto);
}