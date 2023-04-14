using Sentir_Creativo_Backend.CuponDescuentos.Entities.DTO;
using Sentir_Creativo_Backend.CuponDescuentos.Entities.ViewModels;

namespace Sentir_Creativo_Backend.CuponDescuentos.Entities.Mappings;

public static class CuponDescuentoMapping
{
    public static IReadOnlyList<IdCuponDescuentoViewModel> Handle(IReadOnlyList<IdCuponDescuentoDto> dtos)
    {
        return dtos
            .Select(p => 
                new IdCuponDescuentoViewModel() { CuponDescuentoId = p.CuponDescuentoId })
            .ToList()
            .AsReadOnly();
    }
}