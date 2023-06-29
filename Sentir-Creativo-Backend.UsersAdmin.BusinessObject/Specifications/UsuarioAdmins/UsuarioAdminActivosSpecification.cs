namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;

public class UsuarioAdminActivosSpecification : BaseSpecification<UsuarioAdmin>
{
    public UsuarioAdminActivosSpecification()
        : base(x => x.Activo == true)
    {
        
    }
}