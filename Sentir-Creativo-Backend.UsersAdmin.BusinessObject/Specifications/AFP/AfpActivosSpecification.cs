namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.AFP;

public class AfpActivosSpecification : BaseSpecification<Afp>
{
    public AfpActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}