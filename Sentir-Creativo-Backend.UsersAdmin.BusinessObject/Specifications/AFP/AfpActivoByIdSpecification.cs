namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.AFP;

public class AfpActivoByIdSpecification : BaseSpecification<Afp>
{
    public AfpActivoByIdSpecification(int id)
        : base(p => p.Id == id && p.Activo == true)
    {
    }
}