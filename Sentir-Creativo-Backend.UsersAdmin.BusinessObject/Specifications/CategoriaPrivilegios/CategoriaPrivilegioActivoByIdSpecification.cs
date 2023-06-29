namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.CategoriaPrivilegios;

public class CategoriaPrivilegioActivoByIdSpecification : BaseSpecification<CategoriaPrivilegio>
{
    public CategoriaPrivilegioActivoByIdSpecification(int categoriaPrivilegioId): 
        base(x => x.Id == categoriaPrivilegioId && x.Activo == true )
    {
        
    }
}