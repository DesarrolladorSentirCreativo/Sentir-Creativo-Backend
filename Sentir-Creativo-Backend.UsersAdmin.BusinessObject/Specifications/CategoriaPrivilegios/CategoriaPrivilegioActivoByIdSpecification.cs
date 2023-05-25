using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.CategoriaPrivilegios;

public class CategoriaPrivilegioActivoByIdSpecification : BaseSpecification<CategoriaPrivilegio>
{
    public CategoriaPrivilegioActivoByIdSpecification(int categoriaPrivilegioId): 
        base(x => x.Id == categoriaPrivilegioId && x.Activo == true )
    {
        
    }
}