namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ModoTrabajos;

public class ModoTrabajoActivoByIdSpecification : BaseSpecification<ModoTrabajo>
{
    public ModoTrabajoActivoByIdSpecification(int id)
        : base(x => x.Activo == true && x.Id == id)
    {
    }
}