
using Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;
using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Mappings;

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