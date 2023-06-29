namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ModoTrabajos;

public class ModoTrabajoActivosSpecification : BaseSpecification<ModoTrabajo>
{
    public ModoTrabajoActivosSpecification()
        : base(x => x.Activo == true)
    {
    }
}