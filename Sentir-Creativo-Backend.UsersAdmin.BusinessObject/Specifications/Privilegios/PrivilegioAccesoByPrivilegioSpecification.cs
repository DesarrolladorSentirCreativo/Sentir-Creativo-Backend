using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Privilegios;

public class PrivilegioAccesoByPrivilegioSpecification : BaseSpecification<PrivilegioAcceso>
{
    public PrivilegioAccesoByPrivilegioSpecification(string privilegioId)
        : base(p => p.PrivilegioId == privilegioId)
    {
        
    }
}