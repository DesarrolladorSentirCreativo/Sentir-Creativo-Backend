namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.EstadoServicios;

public class EstadoServicioActivosSpecification : BaseSpecification<EstadoServicio>
{
    public EstadoServicioActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}