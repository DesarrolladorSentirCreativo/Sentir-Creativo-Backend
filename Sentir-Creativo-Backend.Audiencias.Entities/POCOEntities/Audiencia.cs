using Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;

public class Audiencia : BaseEntity<int>
{
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Profesion { get; set; }
    public string? Email { get; set; }
    public long? Celular { get; set; }
    public int? OrganizacionId { get; set; }
    public string? Departamento { get; set; }
    public string? Cargo { get; set; }
    public int? AntiguedadId { get; set; }
    public int? CercaniaId { get; set; }
    public int? MotivacionId { get; set; }
    public int? EstadoId { get; set; }
    public int? PrefijoId { get; set; }
    public int? OrigenId { get; set; }
    public string? Email2 { get; set; }
    public bool? Destacado { get; set; }
    public string? DocumentoIdentidad  { get; set; }
    public bool Activo { get; set; }
    public DateTime CreatedAt { get; set; }
    public int? CreatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? PublishedAt { get; set; }
    public int? UpdatedBy { get; set; }

    //relaciones
    public virtual Motivacion? Motivacion { get; set; }
    public virtual Antiguedad? Antiguedad { get; set; }
    public virtual Cercania? Cercania { get; set; }
    public virtual EstadoAudiencia? EstadoAudiencia { get; set; }
    public virtual Prefijo? Prefijo { get; set; }
    public virtual Origen? Origen { get; set; }
    public virtual Organizacion? Organizacion { get; set; }

}