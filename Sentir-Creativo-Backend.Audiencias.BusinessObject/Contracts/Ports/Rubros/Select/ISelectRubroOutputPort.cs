using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Rubros;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Rubros.Select;

public interface ISelectRubroOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectRubroViewModel> viewModels);
}