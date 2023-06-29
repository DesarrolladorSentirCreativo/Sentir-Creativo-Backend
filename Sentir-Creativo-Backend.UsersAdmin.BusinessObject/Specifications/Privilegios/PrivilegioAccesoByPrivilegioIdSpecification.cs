namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Privilegios;

public class PrivilegioAccesoByPrivilegioIdSpecification : BaseSpecification<PrivilegioAcceso>
{
    public PrivilegioAccesoByPrivilegioIdSpecification(string privilegioId) 
        : base(x => x.PrivilegioId == privilegioId)
    {
        
    }
}