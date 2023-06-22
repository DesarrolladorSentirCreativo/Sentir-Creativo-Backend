using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins
{
    public class UsuarioArchivoByIdUsuarioSpecification : BaseSpecification<UsuarioArchivo>
    {
        public UsuarioArchivoByIdUsuarioSpecification(int usuarioAdminId) 
            : base(p => p.UsuarioId == usuarioAdminId)
        {
        }
    }
}
    

