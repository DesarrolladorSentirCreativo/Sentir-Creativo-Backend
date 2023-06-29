namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Previsiones;

public class PrevisionActivoByIdSpecification : BaseSpecification<Prevision>
{
    public PrevisionActivoByIdSpecification(int id)
        : base(p => p.Activo == true && p.Id == id)
    {
    }
}