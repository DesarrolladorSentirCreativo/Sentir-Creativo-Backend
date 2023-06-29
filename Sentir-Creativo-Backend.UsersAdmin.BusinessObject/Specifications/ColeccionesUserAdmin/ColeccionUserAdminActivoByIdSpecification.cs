namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ColeccionesUserAdmin;

public class ColeccionUserAdminActivoByIdSpecification : BaseSpecification<ColeccionUserAdmin>
{
    public ColeccionUserAdminActivoByIdSpecification(int coleccionUserAdminId) : base(x =>
        x.Id == coleccionUserAdminId && x.Activo == true)
    {
        
    }
}