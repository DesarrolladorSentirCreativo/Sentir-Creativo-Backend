namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;

public class UsuarioAcuerdoByIdUsuarioSpecification : BaseSpecification<UsuarioAcuerdo>
{
    public UsuarioAcuerdoByIdUsuarioSpecification(int usuarioAdminId)
        : base(x => x.UsuarioId == usuarioAdminId)
    {
        
    }
}