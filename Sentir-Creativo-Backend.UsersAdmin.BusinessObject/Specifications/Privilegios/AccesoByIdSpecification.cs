using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Privilegios;

public class AccesoByIdSpecification : BaseSpecification<Acceso>
{
    public AccesoByIdSpecification(IReadOnlyList<AccesoId> accesos)
        : base(p => accesos.Select(a => a.Id).Contains(p.Id))
    {
        
    }
}