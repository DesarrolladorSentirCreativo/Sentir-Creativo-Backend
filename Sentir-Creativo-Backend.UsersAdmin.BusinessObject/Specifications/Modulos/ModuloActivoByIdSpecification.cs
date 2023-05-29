using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Modulos;

public class ModuloActivoByIdSpecification : BaseSpecification<Modulo>
{
    public ModuloActivoByIdSpecification(int moduloId) 
        : base(x => x.Id == moduloId && x.Activo == true)
    {
        
    }
}