using Sentir_Creativo_Backend.Archivos.Entities.DTO;
using Sentir_Creativo_Backend.Archivos.Entities.ViewModels;

namespace Sentir_Creativo_Backend.Archivos.Entities.Mappings;

public static class ArchivoMapping
{
    public static IReadOnlyList<IdArchivoViewModel> Handle(IReadOnlyList<IdArchivoDto> dtos)
    {
        return dtos
            .Select(p => 
                new IdArchivoViewModel() { ArchivoId = p.ArchivoId })
            .ToList()
            .AsReadOnly();
    }
}