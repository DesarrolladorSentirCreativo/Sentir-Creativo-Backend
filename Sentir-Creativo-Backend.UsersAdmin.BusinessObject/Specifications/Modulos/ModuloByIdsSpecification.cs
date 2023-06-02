using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Modulos;

public class ModuloByIdsSpecification : BaseSpecification<Modulo>
{
    public ModuloByIdsSpecification(IReadOnlyList<ColeccionUserAdmin> colecciones)
        : base(p => colecciones.Select(a => a.ModuloId).Contains(p.Id))
    {
        
    }
        
}