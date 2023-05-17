using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Specifications.TipoArchivos;

public class TipoArchivoActivosSpecification  : BaseSpecification<TipoArchivo>
{
    public TipoArchivoActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}