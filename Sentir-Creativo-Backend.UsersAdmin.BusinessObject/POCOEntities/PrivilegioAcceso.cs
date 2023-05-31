using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

public class PrivilegioAcceso : BaseEntity<int>
{
    public int AccesoId { get; set; }
    public int Privilegio { get; set; }
}