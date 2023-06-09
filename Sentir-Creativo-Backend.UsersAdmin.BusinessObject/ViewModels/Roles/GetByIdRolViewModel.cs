using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;

public class GetByIdRolViewModel
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string? Descripcion { get; set; }
    public IReadOnlyList<AcuerdoIdDto> Acuerdos { get; set; }
    public IReadOnlyList<PrivilegioIdDto> Privilegios { get; set; }
}