namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.CategoriaPrivilegios;

public class CategoriaPrivilegioActivosSpecification : BaseSpecification<CategoriaPrivilegio>
{
    public CategoriaPrivilegioActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}