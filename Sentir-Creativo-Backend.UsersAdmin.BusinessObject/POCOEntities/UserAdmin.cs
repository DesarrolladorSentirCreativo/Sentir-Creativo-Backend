

using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

public class UserAdmin : BaseEntity<int>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? UserName { get; set; }
    public string Email { get; set; }
    public string? Password { get; set; }
    public string? ResetPasswordToken { get; set; }
    public string? RegistrationToken { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsBlocked { get; set; }
    public string? PreferedLanguage { get; set; }
}