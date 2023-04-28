using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Direcciones.BusinessObjects.Specifications.Ciudades;

public class CiudadActivosSpecification : BaseSpecification<Ciudad>
{
    public CiudadActivosSpecification() : base(x => x.PaisId == 41)
    {
        
    }
}