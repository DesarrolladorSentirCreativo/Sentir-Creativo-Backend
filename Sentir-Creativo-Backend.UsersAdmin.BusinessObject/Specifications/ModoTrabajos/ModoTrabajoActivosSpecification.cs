using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ModoTrabajos;

public class ModoTrabajoActivosSpecification : BaseSpecification<ModoTrabajo>
{
    public ModoTrabajoActivosSpecification()
        : base(x => x.Activo == true)
    {
    }
}