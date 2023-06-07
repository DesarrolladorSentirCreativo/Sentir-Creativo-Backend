using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.AcuerdosUserAdmin;

public class AcuerdoUserAdminActivosSpecification : BaseSpecification<AcuerdoUserAdmin>
{
    public AcuerdoUserAdminActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}