using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.DTO;

namespace Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Ports.Bitacoras.Create;

public interface ICreateBitacoraInputPort
{
    ValueTask Handle(CreateBitacoraDto dto);
}