namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.EstadoUserAdmins;

public class EstadoUserAdminActivoByIdSpecification : BaseSpecification<EstadoUserAdmin>
{
    public EstadoUserAdminActivoByIdSpecification(int id)
        : base(x => x.Id == id && x.Activo == true)
    {
        
    }
}