namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Privilegios;

public class PrivilegioActivosSpecification : BaseSpecification<Privilegio>
{
    public PrivilegioActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}