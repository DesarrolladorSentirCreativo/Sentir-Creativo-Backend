using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Roles;

public class RolAcuerdoByIdRolSpecification : BaseSpecification<RolAcuerdo>
{
    public RolAcuerdoByIdRolSpecification(int rolId) 
        : base(x => x.RolId == rolId)
    {
        
    }
}