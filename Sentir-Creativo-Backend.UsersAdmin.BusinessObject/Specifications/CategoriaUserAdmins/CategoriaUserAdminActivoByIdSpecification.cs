namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.CategoriaUserAdmins;

public class CategoriaUserAdminActivoByIdSpecification : BaseSpecification<CategoriaUserAdmin>
{
    public CategoriaUserAdminActivoByIdSpecification(int categoriaId)
        : base(x =>
        x.Activo == true && x.Id == categoriaId)
    {
        
    }
}