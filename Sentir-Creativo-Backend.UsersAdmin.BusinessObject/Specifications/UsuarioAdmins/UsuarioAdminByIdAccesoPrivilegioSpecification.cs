namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins
{
    public class UsuarioAdminByIdAccesoPrivilegioSpecification : BaseSpecification<PrivilegioAcceso>
    {
        public UsuarioAdminByIdAccesoPrivilegioSpecification(List<string> privilegiosIds)
            : base(x => privilegiosIds.Contains(x.PrivilegioId))
        {
            AddInclude(x => x.Acceso);
        }
    }
}

            
        
    

