using Sentir_Creativo_Backend.Proyectos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Proyectos.BusinessObject.Specifications.TipoProyectos;

public class TipoProyectoActivosSpecification : BaseSpecification<TipoProyecto>
{
    public TipoProyectoActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}