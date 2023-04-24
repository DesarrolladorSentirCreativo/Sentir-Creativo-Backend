using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.DTO;

namespace Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Controllers.Bitacoras;

public interface ICreateBitacoraController
{
    ValueTask<int> Handle(CreateBitacoraDto dto);
}