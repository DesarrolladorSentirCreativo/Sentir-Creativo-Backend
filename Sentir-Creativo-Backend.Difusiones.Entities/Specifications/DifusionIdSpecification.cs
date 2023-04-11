using Sentir_Creativo_Backend.Difusiones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Specifications;

namespace Sentir_Creativo_Backend.Difusiones.Entities.Specifications;

public class DifusionIdSpecification : BaseSpecification<Difusion>
{
    public DifusionIdSpecification(int difusionId) : base(x => x.Id == difusionId)
    {
        AddInclude(p => p.Plantilla!);
        AddInclude(p => p.Coleccion!);
        AddInclude(p => p.Plataforma!);
        AddInclude(p => p.CuponDescuento!);
    }
}