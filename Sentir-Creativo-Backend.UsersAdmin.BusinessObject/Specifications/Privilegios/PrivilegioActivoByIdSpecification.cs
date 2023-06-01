using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Privilegios;

public class PrivilegioActivoByIdSpecification : BaseSpecification<Privilegio>
{
    public PrivilegioActivoByIdSpecification(string privilegioId) 
        : base(x => x.Id == privilegioId && x.Activo == true)
    {
        
    }
}