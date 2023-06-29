namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.FindByEmailAndPassword;

public class UserAdminFindByEmailSpecification : BaseSpecification<UserAdmin>
{
    public UserAdminFindByEmailSpecification(string email)
        : base(x => x.Email == email)

    {

    }
}