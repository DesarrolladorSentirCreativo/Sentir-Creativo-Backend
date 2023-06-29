namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Services;

public interface IUserAdminTokenService
{
    string GenerateToken(UserAdmin userAdmin);

    bool ComparePassword(string password, string passwordUser);
    string EncryptPassword(string password);
    string GenerateTokenAdmin(UsuarioAdmin userAdmin);
}