namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;

public class UsuarioAdminActivoByIdSpecification : BaseSpecification<UsuarioAdmin>
{
    public UsuarioAdminActivoByIdSpecification(int usuarioAdminId) 
        : base(x => x.Id == usuarioAdminId && x.Activo == true)
    {
    }
}