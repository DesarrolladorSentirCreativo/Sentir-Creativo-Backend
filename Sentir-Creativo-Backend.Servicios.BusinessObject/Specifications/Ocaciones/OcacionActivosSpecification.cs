namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.Ocaciones
{
    public class OcacionActivosSpecification : BaseSpecification<Ocacion>
    {
        public OcacionActivosSpecification() : base(x => x.Activo == true)
        {
        }
    }
}
