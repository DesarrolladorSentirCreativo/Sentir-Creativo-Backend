using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.FindByEmailAndPassword;

public class UserAdminFindByEmailSpecification : BaseSpecification<UserAdmin>
{
    public UserAdminFindByEmailSpecification(string email)
        : base(x => x.Email == email)

    {

    }
}