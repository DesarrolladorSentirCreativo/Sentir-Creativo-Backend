using Sentir_Creativo_Backend.Colecciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Colecciones.BusinessObject.Specifications.Colecciones;

public class ColeccionActivosSpecification : BaseSpecification<Coleccion>
{
    public ColeccionActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}