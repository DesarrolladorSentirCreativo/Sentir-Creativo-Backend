using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;

public class Direccion : BaseEntity<int>
{
    public int PaisId { get; set; }
    public int RegionId { get; set; }
    public int CiudadId { get; set; }
    public string? Calle { get; set; }
    public bool Activo { get; set; }
    public Pais? Pais { get; set; }
    public Region? Region { get; set; }
    public Ciudad? Ciudad { get; set; }
}