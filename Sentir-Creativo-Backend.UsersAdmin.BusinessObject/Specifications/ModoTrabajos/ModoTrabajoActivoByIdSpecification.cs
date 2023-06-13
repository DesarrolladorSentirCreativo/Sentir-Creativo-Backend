using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ModoTrabajos;

public class ModoTrabajoActivoByIdSpecification : BaseSpecification<ModoTrabajo>
{
    public ModoTrabajoActivoByIdSpecification(int id)
        : base(x => x.Activo == true && x.Id == id)
    {
    }
}