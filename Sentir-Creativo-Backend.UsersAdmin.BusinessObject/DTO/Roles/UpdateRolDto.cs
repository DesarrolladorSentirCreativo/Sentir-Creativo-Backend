using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Roles;

public class UpdateRolDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public int UserId { get; set; }
    
    public IReadOnlyList<PrivilegioIdDto> Privilegios { get; set; }
    public IReadOnlyList<AcuerdoIdDto> Acuerdos { get; set; }
}