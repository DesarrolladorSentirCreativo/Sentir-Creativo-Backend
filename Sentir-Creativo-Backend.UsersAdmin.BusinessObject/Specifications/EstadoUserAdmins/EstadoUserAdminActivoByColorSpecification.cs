using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.EstadoUserAdmins;

public class EstadoUserAdminActivoByColorSpecification : BaseSpecification<EstadoUserAdmin>
{
    public EstadoUserAdminActivoByColorSpecification(string color) : base(x => x.Activo == true && x.Color == color)
    {
        
    }
}