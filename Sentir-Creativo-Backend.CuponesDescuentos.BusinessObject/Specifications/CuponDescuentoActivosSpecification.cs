using Sentir_Creativo_Backend.CuponDescuentos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Specifications;

public class CuponDescuentoActivosSpecification : BaseSpecification<CuponDescuento>
{
    public CuponDescuentoActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}