using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Previsiones;

public class PrevisionActivoByIdSpecification : BaseSpecification<Prevision>
{
    public PrevisionActivoByIdSpecification(int id)
        : base(p => p.Activo == true && p.Id == id)
    {
    }
}