using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Roles;

public class RolActivoByIdSpecification : BaseSpecification<Rol>
{
    public RolActivoByIdSpecification(int rolId) 
        : base(x => x.Id == rolId && x.Activo == true)
    {
        ;
    }
}