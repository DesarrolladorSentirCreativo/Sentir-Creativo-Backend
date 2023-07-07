namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.Formatos;

public class FormatoActivosSpecification  : BaseSpecification<Formato>
{
    public FormatoActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}