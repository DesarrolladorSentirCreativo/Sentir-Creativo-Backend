namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.Formatos
{
    public class FormatoByIdActivoSpecification : BaseSpecification<Formato>
    {
        public FormatoByIdActivoSpecification(int formatoId) : base(x => x.Id == formatoId && x.Activo == true)
        {
            
        }
    }
}
