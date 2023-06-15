using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;

public class UsuarioAdminActivoByEmailAndNumDocumentoSpecification : BaseSpecification<UsuarioAdmin>
{
    public UsuarioAdminActivoByEmailAndNumDocumentoSpecification(string email, string numDocumento)
        : base(x => x.Email == email && x.Activo == true || x.NumDocumento == numDocumento && x.Activo == true)
    {
        
    }
}