namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Roles;

public class RolActivoByIdSpecification : BaseSpecification<Rol>
{
    public RolActivoByIdSpecification(int rolId) 
        : base(x => x.Id == rolId && x.Activo == true)
    {
        ;
    }
}