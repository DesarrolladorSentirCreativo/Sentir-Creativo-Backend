namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.CategoriaUserAdmins;

public class CategoriaUserAdminActivosSpecification : BaseSpecification<CategoriaUserAdmin>
{
    public CategoriaUserAdminActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}