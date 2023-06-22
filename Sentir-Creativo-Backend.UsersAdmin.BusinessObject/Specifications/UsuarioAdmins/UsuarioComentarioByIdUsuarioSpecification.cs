using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins
{
    public class UsuarioComentarioByIdUsuarioSpecification : BaseSpecification<UsuarioComentario>
    {
        public UsuarioComentarioByIdUsuarioSpecification(int usuarioAdminId) : base(x => x.UsuarioId == usuarioAdminId)
        {
        }
    }
}
    
