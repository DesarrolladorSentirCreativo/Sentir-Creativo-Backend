namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Roles;

public class RolPrivilegioByIdRolSpecification : BaseSpecification<RolPrivilegio>
{
    public RolPrivilegioByIdRolSpecification(int rolId) 
        : base(x => x.RolId == rolId)
    {
        
    }
}