namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Previsiones;

public class PrevisionActivosSpecification : BaseSpecification<Prevision>
{
    public PrevisionActivosSpecification()
        : base(p => p.Activo == true)
    {
    }
}