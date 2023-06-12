using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.CategoriaUserAdmins;

public class CategoriaUserAdminActivosSpecification : BaseSpecification<CategoriaUserAdmin>
{
    public CategoriaUserAdminActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}