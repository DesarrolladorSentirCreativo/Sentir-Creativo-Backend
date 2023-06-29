namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;

public class UsuarioSucursalByIdUsuarioSpecification : BaseSpecification<UsuarioSucursal>
{
    public UsuarioSucursalByIdUsuarioSpecification(int usuarioAdminId)
        : base(x => x.UsuarioId == usuarioAdminId)
    {
        
    }
}