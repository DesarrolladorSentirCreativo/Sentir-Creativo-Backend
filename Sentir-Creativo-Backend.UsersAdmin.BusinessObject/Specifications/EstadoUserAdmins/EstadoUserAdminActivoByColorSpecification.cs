namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.EstadoUserAdmins;

public class EstadoUserAdminActivoByColorSpecification : BaseSpecification<EstadoUserAdmin>
{
    public EstadoUserAdminActivoByColorSpecification(string color) : base(x => x.Activo == true && x.Color == color)
    {
        
    }
}