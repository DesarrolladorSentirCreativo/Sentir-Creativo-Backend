using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Roles;

public class RolActivosSpecification : BaseSpecification<Rol>
{
    public RolActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}