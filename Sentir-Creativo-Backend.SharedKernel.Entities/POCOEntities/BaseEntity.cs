namespace Sentir_Creativo_Backend.SharedKernel.Entities.POCOEntities;

public abstract class BaseEntity<TId>
{
    public TId Id { get; set; }
}