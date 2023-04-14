using Sentir_Creativo_Backend.Bitacoras.Entities.DTO;
using Sentir_Creativo_Backend.Bitacoras.Entities.ViewModels;

namespace Sentir_Creativo_Backend.Bitacoras.Entities.Mappings;

public static class BitacoraMapping
{
    public static IReadOnlyList<IdBitacoraViewModel> Handle(IReadOnlyList<IdBitacoraDto> dtos)
    {
        return dtos
            .Select(p => 
                new IdBitacoraViewModel() { BitacoraId = p.BitacoraId })
            .ToList()
            .AsReadOnly();
    }
}