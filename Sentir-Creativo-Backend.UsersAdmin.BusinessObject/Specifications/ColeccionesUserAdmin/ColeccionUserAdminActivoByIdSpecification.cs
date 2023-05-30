using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ColeccionesUserAdmin;

public class ColeccionUserAdminActivoByIdSpecification : BaseSpecification<ColeccionUserAdmin>
{
    public ColeccionUserAdminActivoByIdSpecification(int coleccionUserAdminId) : base(x =>
        x.Id == coleccionUserAdminId && x.Activo == true)
    {
        
    }
}