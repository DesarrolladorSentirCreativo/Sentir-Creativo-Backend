using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Roles;

public class RolPrivilegioByIdRolSpecification : BaseSpecification<RolPrivilegio>
{
    public RolPrivilegioByIdRolSpecification(int rolId) 
        : base(x => x.RolId == rolId)
    {
        
    }
}