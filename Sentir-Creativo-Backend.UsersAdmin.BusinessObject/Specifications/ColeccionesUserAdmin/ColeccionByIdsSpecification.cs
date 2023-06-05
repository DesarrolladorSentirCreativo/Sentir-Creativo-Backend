using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ColeccionesUserAdmin;

public class ColeccionByIdsSpecification : BaseSpecification<ColeccionUserAdmin>
{
    public ColeccionByIdsSpecification(IReadOnlyList<Modulo> modulos)
      : base(p => modulos.Select(a => a.Id).Contains(p.ModuloId) && p.Activo == true)
    {
        
    }
}