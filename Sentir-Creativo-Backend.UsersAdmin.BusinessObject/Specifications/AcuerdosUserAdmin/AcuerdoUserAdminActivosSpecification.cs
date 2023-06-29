namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.AcuerdosUserAdmin;

public class AcuerdoUserAdminActivosSpecification : BaseSpecification<AcuerdoUserAdmin>
{
    public AcuerdoUserAdminActivosSpecification() : base(x => x.Activo == true)
    {
        
    }
}