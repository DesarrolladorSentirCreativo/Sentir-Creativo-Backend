using Sentir_Creativo_Backend.Servicios.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.EstadoServicios;

public class EstadoServicioActivosSpecification : BaseSpecification<EstadoServicio>
{
    public EstadoServicioActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}