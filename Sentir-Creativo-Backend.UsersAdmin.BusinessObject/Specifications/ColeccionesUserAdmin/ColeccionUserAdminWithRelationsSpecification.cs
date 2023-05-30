using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ColeccionesUserAdmin;

public class ColeccionUserAdminWithRelationsSpecification : BaseSpecification<ColeccionUserAdmin>
{
    public ColeccionUserAdminWithRelationsSpecification() : base(x => x.Activo == true)
    {
        AddInclude(p => p.Modulo);
    }
}