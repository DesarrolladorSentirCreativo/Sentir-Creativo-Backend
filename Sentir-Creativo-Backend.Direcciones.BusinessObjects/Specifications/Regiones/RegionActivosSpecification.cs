using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Direcciones.BusinessObjects.Specifications.Regiones;

public class RegionActivosSpecification : BaseSpecification<Region>
{
    public RegionActivosSpecification() : base(x => x.PaisId == 41)
    {
        
    }
}