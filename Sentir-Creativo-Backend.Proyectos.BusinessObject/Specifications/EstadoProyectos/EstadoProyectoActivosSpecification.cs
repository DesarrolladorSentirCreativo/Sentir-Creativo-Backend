using Sentir_Creativo_Backend.Proyectos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Proyectos.BusinessObject.Specifications.EstadoProyectos;

public class EstadoProyectoActivosSpecification : BaseSpecification<EstadoProyecto>
{
    public EstadoProyectoActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}