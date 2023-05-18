using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Specifications.Archivos;

public class ArchivoSpecification : BaseSpecification<Archivo>
{
    public ArchivoSpecification(int archivoId) : base(x => x.Id == archivoId)
    {
        AddInclude(p => p.TipoArchivo!);
    }
}