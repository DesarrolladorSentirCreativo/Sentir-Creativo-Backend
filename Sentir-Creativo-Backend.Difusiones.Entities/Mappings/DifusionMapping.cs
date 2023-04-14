using Sentir_Creativo_Backend.Difusiones.Entities.DTO;
using Sentir_Creativo_Backend.Difusiones.Entities.ViewModels;

namespace Sentir_Creativo_Backend.Difusiones.Entities.Mappings;

public static class DifusionMapping
{
    public static IReadOnlyList<IdDifusionViewModel> Handle(IReadOnlyList<IdDifusionDto> dtos)
    {
        return dtos
            .Select(p => 
                new IdDifusionViewModel() { DifusionId = p.DifusionId })
            .ToList()
            .AsReadOnly();
    }
}