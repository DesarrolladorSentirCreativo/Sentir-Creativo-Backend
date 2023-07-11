namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.EstadoServicios
{
    public class EstadoServicioByColorSpecification : BaseSpecification<EstadoServicio>
    {
        public EstadoServicioByColorSpecification(string color) : base(x => x.Color!.Contains(color) && x.Activo == true)
        {
        }
    }
}
