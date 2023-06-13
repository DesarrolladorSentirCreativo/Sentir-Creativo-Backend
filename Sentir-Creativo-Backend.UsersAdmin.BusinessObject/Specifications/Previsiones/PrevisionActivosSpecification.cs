using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Previsiones;

public class PrevisionActivosSpecification : BaseSpecification<Prevision>
{
    public PrevisionActivosSpecification()
        : base(p => p.Activo == true)
    {
    }
}