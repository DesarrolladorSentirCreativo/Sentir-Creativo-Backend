using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Cercanias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Cercanias.Select;

public interface ISelectCercaniaOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectCercaniaViewModel> modelView);
}