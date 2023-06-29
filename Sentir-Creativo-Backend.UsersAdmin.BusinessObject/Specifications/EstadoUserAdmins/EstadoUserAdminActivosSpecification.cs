namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.EstadoUserAdmins;

public class EstadoUserAdminActivosSpecification : BaseSpecification<EstadoUserAdmin>
{
    public EstadoUserAdminActivosSpecification()
        : base(x => x.Activo == true)
    {
    }
}