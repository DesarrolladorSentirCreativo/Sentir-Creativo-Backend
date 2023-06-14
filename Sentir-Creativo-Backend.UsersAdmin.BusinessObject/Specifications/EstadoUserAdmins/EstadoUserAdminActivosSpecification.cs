using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.EstadoUserAdmins;

public class EstadoUserAdminActivosSpecification : BaseSpecification<EstadoUserAdmin>
{
    public EstadoUserAdminActivosSpecification()
        : base(x => x.Activo == true)
    {
    }
}