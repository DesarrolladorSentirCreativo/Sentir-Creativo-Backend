namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.EstadoServicios
{
    public class EstadoServicioByIdActivoSpecification : BaseSpecification<EstadoServicio>
    {
        public EstadoServicioByIdActivoSpecification(int estadoServicioId) 
            : base(x => x.Activo == true && x.Id == estadoServicioId)
        {

        }
   }
}