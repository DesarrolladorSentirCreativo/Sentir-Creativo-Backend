namespace Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

public class UserAdmin : BaseEntity<int>
{
    public string? UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string? Provider { get; set; }
    public string? ResetPasswordToken { get; set; }
    public string? ConfirmationToken { get; set; }
    public bool? Blocked { get; set; }
    public bool? Confirmed { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int? UpdatedBy { get; set; }
    public int RoleId { get; set; }
}