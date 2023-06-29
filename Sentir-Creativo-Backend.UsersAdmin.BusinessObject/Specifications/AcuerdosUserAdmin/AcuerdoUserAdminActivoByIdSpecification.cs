namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.AcuerdosUserAdmin;

public class AcuerdoUserAdminActivoByIdSpecification : BaseSpecification<AcuerdoUserAdmin>
{
    public AcuerdoUserAdminActivoByIdSpecification(int acuerdoId) 
        : base(x => x.Id == acuerdoId && x.Activo)
    {
    }
}